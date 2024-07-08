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
    public partial class CreateRejestracja : Form
    {
        public CreateRejestracja ()
        {
            InitializeComponent();
            S.Pacjent = null;
            S.PacjentId = null;
            S.Zdjecia.Clear();
            S.SetPictureBoxBorder(pictureBox1);

        }

        private async void CreateRejestracja_Load (object sender, EventArgs e)
        {
            comboBoxLekarze.DataSource = (await S.LekarzeService.GetAll())
                .Select(s => s.Nazwisko)
                .ToList();  
        }

        private async void CreateRejestracja_Activated (object sender, EventArgs e)
        {
            // Wyświetlenie danych pacjenta po skorzystaniu z wyszukiwarki
            if (!string.IsNullOrEmpty(S.PacjentId))
                S.Pacjent = await S.PacjenciService.Get(S.PacjentId);
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
                    .Where (w=> w.PacjentId == S.PacjentId)
                    .ToList ();
                S.SetItemsInListBox(zdjecia.Select(s => s.Nazwa).ToList(), listBoxZdjecia);


                buttonDodajPacjenta.Enabled = false;
            }
        }


        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                 
                if (S.IsValid(new List<TextBox>() { textBoxNumerRejestracji, textBoxGabinet, textBoxImie, textBoxNazwisko, textBoxUlica, textBoxPesel, textBoxMiejscowosc }))
                {  
                    // Wizytka
                    var lekarz = (await S.LekarzeService.GetAll ())
                        .FirstOrDefault (w=> w.Nazwisko == comboBoxLekarze.SelectedItem.ToString ());

                    Rejestracja rejestracja = new Rejestracja ()
                    {
                        RejestracjaId = Guid.NewGuid ().ToString (),
                        NaKiedy = dateTimePickerNaKiedy.Value,
                        NumerRejestracji = int.Parse (textBoxNumerRejestracji.Text),
                        Gabinet = textBoxGabinet.Text,
                        LekarzId = lekarz.LekarzId,
                        PacjentId = S.Pacjent.PacjentId,
                        DataRejestracji = DateTime.Now
                    };
                    await S.RejestracjeService.Create(rejestracja);

                    Cursor = Cursors.Default;
                    MessageBox.Show("Dane został dodane");
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

        private void tabPage1_Click (object sender, EventArgs e)
        {

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

        private void button1_Click (object sender, EventArgs e)
        {
            PacjentSzukaj ps = new PacjentSzukaj ();
            ps.ShowDialog ();
        }

        private async void buttonDodajPacjenta_Click (object sender, EventArgs e)
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
                        if (!string.IsNullOrEmpty(zdjecie))
                            pacjentZdjecie.Data = S.GetBytes(zdjecie);
                        await S.PacjenciZdjeciaService.Create(pacjentZdjecie);
                    }

                    S.Pacjent = pacjent;
                    buttonDodajPacjenta.Enabled = false;
                    Cursor = Cursors.Default;
                    MessageBox.Show("Dane zostały dodane poprawnie"); 
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

    }
}
