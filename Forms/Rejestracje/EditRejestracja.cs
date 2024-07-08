using Domain;
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

namespace WinFormsApp96.Forms.Rejestracje
{
    public partial class EditRejestracja : Form
    {
        public EditRejestracja ()
        {
            InitializeComponent();
            S.Zdjecia.Clear();
            S.SetPictureBoxBorder(pictureBox1);
        }

        private async void EditRejestracja_Load (object sender, EventArgs e)
        {
            comboBoxLekarze.DataSource = (await S.LekarzeService.GetAll())
                .Select(s => s.Nazwisko)
                .ToList();


            S.Rejestracja = await S.RejestracjeService.Get (S.RejestracjaId);
            if (S.Rejestracja != null)
            {
                S.Lekarz = await S.LekarzeService.Get (S.Rejestracja.LekarzId);
                S.Pacjent = await S.PacjenciService.Get (S.Rejestracja.PacjentId);

                if (S.Lekarz != null)
                    comboBoxLekarze.SelectedItem = S.Lekarz.Nazwisko;


                // Wyświetlenie danych pacjenta
                if (S.Pacjent != null)
                {
                    textBoxImie.Text = S.Pacjent.Imie;
                    textBoxNazwisko.Text = S.Pacjent.Nazwisko;
                    textBoxUlica.Text = S.Pacjent.Ulica;
                    textBoxPesel.Text = S.Pacjent.Pesel;
                    textBoxMiejscowosc.Text = S.Pacjent.Miejscowosc;
                    dateTimePickerDataUrodzenia.Value = S.Pacjent.DataUrodzenia;
                    textBoxUwagi.Text = S.Pacjent.Uwagi;

                    // Wyświetlenie zdjęc
                    var zdjecia = (await S.PacjenciZdjeciaService.GetAll ())
                        .Where (w=> w.PacjentId == S.Pacjent.PacjentId)
                        .ToList (); 
                    S.SetItemsInListBox(zdjecia.Select(s => s.Nazwa).ToList(), listBoxZdjecia);
                }




                // Wyświetlenie danych rejestracji
                dateTimePickerNaKiedy.Value = S.Rejestracja.NaKiedy;
                textBoxNumerRejestracji.Text = S.Rejestracja.NumerRejestracji.ToString ();
                textBoxGabinet.Text = S.Rejestracja.Gabinet;
            }
        }

        private void textBoxUwagi_TextChanged (object sender, EventArgs e)
        {

        }

        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor; 

                // Modyfikacja rejestracji
                if (S.Rejestracja != null)
                {
                    S.Rejestracja.NaKiedy = dateTimePickerNaKiedy.Value;
                    S.Rejestracja.NumerRejestracji = int.Parse (textBoxNumerRejestracji.Text);
                    S.Rejestracja.Gabinet = textBoxGabinet.Text;
                }


                // Modyfikacja pacjenta
                if (S.Pacjent != null)
                { 
                    if (S.IsValid(new List<TextBox>() { textBoxImie, textBoxNazwisko, textBoxUlica, textBoxPesel, textBoxMiejscowosc }))
                    {
                        S.Pacjent.Imie = textBoxImie.Text;
                        S.Pacjent.Nazwisko = textBoxNazwisko.Text;
                        S.Pacjent.Ulica = textBoxUlica.Text;
                        S.Pacjent.Pesel = textBoxPesel.Text;
                        S.Pacjent.Miejscowosc = textBoxMiejscowosc.Text;
                        S.Pacjent.DataUrodzenia = dateTimePickerDataUrodzenia.Value;
                        S.Pacjent.Uwagi = textBoxUwagi.Text;

                        await S.PacjenciService.Edit(S.Pacjent.PacjentId, S.Pacjent);



                        // Dodanie zdjęć
                        foreach (var zdjecie in S.Zdjecia)
                        {
                            PacjentZdjecie pacjentZdjecie = new PacjentZdjecie ()
                            {
                                PacjentZdjecieId = Guid.NewGuid ().ToString (),
                                Nazwa = zdjecie,
                                PacjentId = S.Pacjent.PacjentId
                            };
                            if (!string.IsNullOrEmpty(zdjecie))
                                pacjentZdjecie.Data = S.GetBytes(zdjecie);
                            await S.PacjenciZdjeciaService.Create(pacjentZdjecie);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wszystkie pola muszą być wypełnione poprawnie");
                    }
                }

                Cursor = Cursors.Default;
                MessageBox.Show("Dane zostały dodane poprawnie");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonZamknij_Click (object sender, EventArgs e)
        {

        }

        private void listBoxZdjecia_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (listBoxZdjecia.SelectedItem != null)
                pictureBox1.Image = S.GetImage(listBoxZdjecia.SelectedItem.ToString());
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
                pictureBox1.Image = null;
                if (listBoxZdjecia.Items.Count > 0)
                    listBoxZdjecia.SelectedIndex = 0;
                S.SetItemsFromListBoxToListZdjecia(listBoxZdjecia);
            }
        }
    }
}
