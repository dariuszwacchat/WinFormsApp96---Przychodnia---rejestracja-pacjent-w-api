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
    public partial class EditPacjent : Form
    {
        public EditPacjent ()
        {
            InitializeComponent();
            S.Zdjecia.Clear(); 
            S.SetPictureBoxBorder (pictureBox1);
            S.SetDataGridViewStyles2 (dataGridViewRejestracje);
        }

        private async void EditPacjent_Load (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (S.PacjentId))
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
                S.SetItemsInListBox (zdjecia.Select (s=>s.Nazwa).ToList(), listBoxZdjecia);

                DisplayRejestracje ();


                if (toolStripComboBoxWizyty.Items.Count > 0)
                    toolStripComboBoxWizyty.SelectedIndex = 0;
            }
        }
        private async void DisplayRejestracje ()
        {
            try
            {
                S.Index = 0;
                var rejestracje = (await S.RejestracjeService.GetAll ())
                        .Where (w=> w.PacjentId == S.PacjentId)
                        .ToList ();

                List <Rejestracja> rejestracjeOdfiltrowane = new List<Rejestracja> ();
                if (toolStripComboBoxWizyty.SelectedItem != null)
                {
                    if (toolStripComboBoxWizyty.SelectedItem.ToString() == "Tygodniu")
                    {
                        rejestracjeOdfiltrowane.Clear();
                        foreach (var r in rejestracje)
                            if (S.TerminKonczySieWtymTygodniu(r.NaKiedy))
                                rejestracjeOdfiltrowane.Add(r);
                    }
                    else if (toolStripComboBoxWizyty.SelectedItem.ToString() == "Miesiącu")
                    {
                        rejestracjeOdfiltrowane.Clear();
                        foreach (var r in rejestracje)
                            if (S.TerminKonczySieWtymMiesiacu(r.NaKiedy))
                                rejestracjeOdfiltrowane.Add(r);
                    }
                }


                dataGridViewRejestracje.DataSource = (from f in rejestracjeOdfiltrowane
                                                      select new
                                                      {
                                                          RejestracjaId = f.RejestracjaId,
                                                          Lp = S.IndexCounter,
                                                          DataRejestracji = f.DataRejestracji.ToShortDateString(),
                                                          NaKiedy = f.NaKiedy,
                                                          Gabinet = f.Gabinet,
                                                          NumerRejestracji = f.NumerRejestracji,
                                                          PacjentId = f.PacjentId,
                                                          LekarzId = f.LekarzId,
                                                      }).ToList();
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
                if (S.Pacjent != null)
                {
                    Cursor = Cursors.WaitCursor;

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

                        Cursor = Cursors.Default;
                        MessageBox.Show("Dane został dodane poprawnie");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Wszystkie pola muszą być wypełnione poprawnie");
                    }

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
                var zdjecie = (await S.PacjenciZdjeciaService.GetAll ())
                    .FirstOrDefault (f=> f.Nazwa == listBoxZdjecia.SelectedItem.ToString () && f.PacjentId == S.Pacjent.PacjentId);
                if (zdjecie != null)
                {
                    var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        await S.PacjenciZdjeciaService.Delete(zdjecie.PacjentZdjecieId);

                        var zdjecia = (await S.PacjenciZdjeciaService.GetAll())
                            .Where(w => w.PacjentId == S.Pacjent.PacjentId)
                            .ToList();
                        pictureBox1.Image = null;
                        S.SetItemsInListBox(zdjecia.Select(s => s.Nazwa).ToList(), listBoxZdjecia);
                    }
                }
                else
                {
                    MessageBox.Show("Nie można odnaleźć zdjęcia");
                }
            }
            catch { }
        }

        private void listBoxZdjecia_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (listBoxZdjecia.SelectedItem != null)
                pictureBox1.Image = S.GetImage(listBoxZdjecia.SelectedItem.ToString());
        }

        private void toolStripComboBoxWizyty_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayRejestracje ();
        }
    }
}
