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
    public partial class UserCreate : Form
    {
        public UserCreate ()
        {
            InitializeComponent();
            S.Zdjecia.Clear ();
            S.SetPictureBoxBorder (pictureBox1); 
            S.DisplayAllRoles(panelUprawnienia);
        }

        private void UserCreate_Load (object sender, EventArgs e)
        {

        }

        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                if (S.IsValid(new List<TextBox>() { textBoxImie, textBoxNazwisko, textBoxUlica, textBoxPesel, textBoxMiejscowosc }))
                {
                    Cursor = Cursors.WaitCursor;
                     
                    ApplicationUser user = new ApplicationUser ()
                    {
                        Id = Guid.NewGuid ().ToString (),
                        Imie = textBoxImie.Text,
                        Nazwisko = textBoxNazwisko.Text,
                        Ulica = textBoxUlica.Text,
                        Pesel = textBoxPesel.Text,
                        Miejscowosc = textBoxMiejscowosc.Text,
                        DataUrodzenia = dateTimePickerDataUrodzenia.Value,
                        ZatrudnionyOd = DateTime.Now,
                        Uwagi = textBoxUwagi.Text
                    };
                    CreateUserViewModel createUserViewModel = new CreateUserViewModel ()
                    {
                        User = user,
                        Password = "SDG%$@5423sdgagSDert"
                    };
                    await S.UsersService.Create (createUserViewModel);



                    // Dodanie użytkownika do roli  
                    foreach (var rola in S.ListaRol) 
                        S.PrzypiszUzytkownikaDoRoli(rola, user); 
                     


                    // Dodanie zdjęć 
                    foreach (var zdjecie in S.Zdjecia)
                    {
                        ApplicationUserZdjecie userZdjecie = new ApplicationUserZdjecie ()
                        {
                            ApplicationUserZdjecieId = Guid.NewGuid ().ToString (),
                            Nazwa = zdjecie,
                            Data = S.GetBytes (zdjecie),
                            UserId = user.Id
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

        private void buttonUsunZdjecie_Click (object sender, EventArgs e)
        {
            if (listBoxZdjecia.Items.Count > 0)
            {
                listBoxZdjecia.Items.RemoveAt(listBoxZdjecia.SelectedIndex);
                S.SetItemsFromListBoxToListZdjecia(listBoxZdjecia);
            }
        }

        private void listBoxZdjecia_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (listBoxZdjecia.SelectedItem != null)
                pictureBox1.Image = S.GetImage(listBoxZdjecia.SelectedItem.ToString());
        }

    }
}
