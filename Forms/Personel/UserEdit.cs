using Domain;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp96.Services;

namespace WinFormsApp95.Forms.Personel
{
    public partial class UserEdit : Form
    {
        public UserEdit ()
        {
            InitializeComponent();
            S.Zdjecia.Clear();
            S.SetPictureBoxBorder(pictureBox1);
        }

        private async void UserEdit_Load (object sender, EventArgs e)
        {
            try
            {
                S.User = await S.UsersService.GetUserById(S.UserId);
                if (S.User != null)
                {
                    textBoxImie.Text = S.User.Imie;
                    textBoxNazwisko.Text = S.User.Nazwisko;
                    textBoxUlica.Text = S.User.Ulica;
                    textBoxPesel.Text = S.User.Pesel;
                    textBoxMiejscowosc.Text = S.User.Miejscowosc;
                    dateTimePickerDataUrodzenia.Value = S.User.DataUrodzenia;
                    textBoxUwagi.Text = S.User.Uwagi;


                    // Wyświetlenie wszystkich ról wraz z tymi do których należy
                    S.DisplayAllRolesISprawdzCzyDoNiejNalezy(panelUprawnienia, S.User);



                    // Wyświetlenie zdjęc
                    var userZdjecia = (await S.UsersZdjeciaService.GetAll ())
                    .Where (w=> w.UserId == S.User.Id)
                    .ToList ();
                    S.SetItemsInListBox(userZdjecia.Select(s => s.Nazwa).ToList(), listBoxZdjecia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                if (S.IsValid(new List<TextBox>() { textBoxImie, textBoxNazwisko, textBoxUlica, textBoxPesel, textBoxMiejscowosc }))
                {
                    Cursor = Cursors.WaitCursor;

                    S.User.Imie = textBoxImie.Text;
                    S.User.Nazwisko = textBoxNazwisko.Text;
                    S.User.Ulica = textBoxUlica.Text;
                    S.User.Pesel = textBoxPesel.Text;
                    S.User.Miejscowosc = textBoxMiejscowosc.Text;
                    S.User.DataUrodzenia = dateTimePickerDataUrodzenia.Value;
                    S.User.Uwagi = textBoxUwagi.Text;

                    CreateUserViewModel createUserViewModel = new CreateUserViewModel ()
                    {
                        User = S.User,
                        Password = "SDG%$@5423sdgagSDert"
                    };
                    await S.UsersService.Edit(S.User.Id, S.User);



                    // Dodanie zdjęć 
                    foreach (var zdjecie in S.Zdjecia)
                    {
                        ApplicationUserZdjecie userZdjecie = new ApplicationUserZdjecie ()
                        {
                            ApplicationUserZdjecieId = Guid.NewGuid ().ToString (),
                            Nazwa = zdjecie,
                            Data = S.GetBytes (zdjecie),
                            UserId = S.User.Id
                        };
                        await S.UsersZdjeciaService.Create(userZdjecie);
                    }




                    Cursor = Cursors.Default;
                    MessageBox.Show("Dane zostały zapisane poprawnie");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wszystkie pola muszą być wypełnione poprawnie");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonZamknij_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodajZdjecie_Click (object sender, EventArgs e)
        {
            S.Zdjecia.Clear();
            OpenFileDialog open = new OpenFileDialog () { Multiselect = true };
            if (open.ShowDialog() == DialogResult.OK)
            {
                S.Zdjecia = open.FileNames.ToList();
                S.SetItemsInListBox(open.FileNames.ToList(), listBoxZdjecia);
            }
        }

        private async void buttonUsunZdjecie_Click (object sender, EventArgs e)
        {
            try
            {
                if (listBoxZdjecia.Items.Count > 0)
                {
                    var userZdjecie = (await S.UsersZdjeciaService.GetAll ())
                        .FirstOrDefault (f=> f.Nazwa == listBoxZdjecia.SelectedItem.ToString () && f.UserId == S.User.Id);
                    if (userZdjecie != null)
                    {
                        var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (message == DialogResult.Yes)
                        {
                            await S.UsersZdjeciaService.Delete(userZdjecie.ApplicationUserZdjecieId);

                            var userZdjecia = (await S.UsersZdjeciaService.GetAll())
                                .Where(w => w.UserId == S.User.Id)
                                .ToList();
                            pictureBox1.Image = null;
                            S.SetItemsInListBox(userZdjecia.Select(s => s.Nazwa).ToList(), listBoxZdjecia);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nie można odnaleźć zdjęcia");
                    }
                }
            }
            catch { }
        }

        private void listBoxZdjecia_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (listBoxZdjecia.SelectedItem != null)
                pictureBox1.Image = S.GetImage(listBoxZdjecia.SelectedItem.ToString());
        }
    }
}
