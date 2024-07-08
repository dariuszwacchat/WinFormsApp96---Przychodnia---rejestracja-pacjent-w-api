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

namespace WinFormsApp96.Forms.Pacjenci
{
    public partial class CreatePacjent : Form
    {
        public CreatePacjent ()
        {
            InitializeComponent();
            S.Zdjecia.Clear ();
            S.SetPictureBoxBorder (pictureBox1);
        }

        private void CreatePacjent_Load (object sender, EventArgs e)
        {

        }

        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (S.IsValid(new List<TextBox>() { textBoxImie, textBoxNazwisko, textBoxUlica, textBoxPesel, textBoxMiejscowosc }))
                {
                    Pacjent pacjent = new Pacjent ()
                    {
                        PacjentId = Guid.NewGuid ().ToString (),
                        Imie = textBoxImie.Text,
                        Nazwisko = textBoxNazwisko.Text,
                        Ulica = textBoxUlica.Text,
                        Pesel = textBoxPesel.Text,
                        Miejscowosc = textBoxMiejscowosc.Text,
                        DataUrodzenia = dateTimePickerDataUrodzenia.Value,
                        Uwagi = textBoxUwagi.Text,
                        DataDodania = DateTime.Now
                    };
                    await S.PacjenciService.Create(pacjent);



                    // Dodanie zdjęć
                    foreach (var zdjecie in S.Zdjecia)
                    {
                        PacjentZdjecie pacjentZdjecie = new PacjentZdjecie ()
                        { 
                            PacjentZdjecieId = Guid.NewGuid ().ToString (),
                            Nazwa = zdjecie,
                            PacjentId = pacjent.PacjentId
                        };
                        if (!string.IsNullOrEmpty (zdjecie))
                            pacjentZdjecie.Data = S.GetBytes (zdjecie);
                        await S.PacjenciZdjeciaService.Create (pacjentZdjecie);
                    }


                }
                else
                {
                    MessageBox.Show("Wszystkie pola muszą być wypełnione poprawnie");
                }

                Cursor = Cursors.Default;
                MessageBox.Show("Dane został dodane");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonZamknij_Click (object sender, EventArgs e)
        {
            Close ();
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

        private void listBoxZdjecia_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (listBoxZdjecia.SelectedItem != null)
                pictureBox1.Image = S.GetImage(listBoxZdjecia.SelectedItem.ToString());
        }
    }
}
