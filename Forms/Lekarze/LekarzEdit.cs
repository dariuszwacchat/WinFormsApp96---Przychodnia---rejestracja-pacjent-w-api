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

namespace WinFormsApp96.Forms.Lekarze
{
    public partial class LekarzEdit : Form
    {
        public LekarzEdit ()
        {
            InitializeComponent();
            S.Zdjecia.Clear ();
            S.SetPictureBoxBorder(pictureBox1);
            S.SetDataGridViewStyles2 (dataGridViewRejestracje);
        }

        private async void LekarzEdit_Load (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (S.LekarzId))
                S.Lekarz = await S.LekarzeService.Get (S.LekarzId);
            
            if (S.Lekarz != null)
            {
                textBoxImie.Text = S.Lekarz.Imie;
                textBoxNazwisko.Text = S.Lekarz.Nazwisko;
                textBoxUlica.Text = S.Lekarz.Ulica;
                textBoxPesel.Text = S.Lekarz.Pesel;
                textBoxMiejscowosc.Text = S.Lekarz.Miejscowosc;
                dateTimePickerDataUrodzenia.Value = S.Lekarz.DataUrodzenia;
                textBoxUwagi.Text = S.Lekarz.Uwagi;

                // Wyświetlenie zdjęc
                var zdjecia = (await S.LekarzeZdjeciaService.GetAll ())
                    .Where (w=> w.LekarzId == S.Lekarz.LekarzId)
                    .ToList ();
                S.SetItemsInListBox(zdjecia.Select(s => s.Nazwa).ToList(), listBoxZdjecia);



                // Wyświetlenie specjalizacji
                S.SprawdzDoJakichSpecjalizacjiPrzypisanyJestDanyLekarz(panelSpecjalizacje, S.Lekarz);

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
                        .Where (w=> w.LekarzId == S.LekarzId)
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
                if (S.IsValid(new List<TextBox>() { textBoxImie, textBoxNazwisko, textBoxUlica, textBoxPesel, textBoxMiejscowosc }))
                {

                    Cursor = Cursors.WaitCursor;

                    S.Lekarz.Imie = textBoxImie.Text;
                    S.Lekarz.Nazwisko = textBoxNazwisko.Text;
                    S.Lekarz.Ulica = textBoxUlica.Text;
                    S.Lekarz.Pesel = textBoxPesel.Text;
                    S.Lekarz.Miejscowosc = textBoxMiejscowosc.Text;
                    S.Lekarz.DataUrodzenia = dateTimePickerDataUrodzenia.Value;
                    S.Lekarz.Uwagi = textBoxUwagi.Text;  

                    await S.LekarzeService.Edit(S.Lekarz.LekarzId, S.Lekarz);
                      


                    // Dodanie zdjęć
                    foreach (var zdjecie in S.Zdjecia)
                    {
                        LekarzZdjecie lekarzZdjecie = new LekarzZdjecie ()
                        {
                            LekarzZdjecieId = Guid.NewGuid ().ToString (),
                            Nazwa = zdjecie,
                            LekarzId = S.Lekarz.LekarzId
                        };
                        if (!string.IsNullOrEmpty(zdjecie))
                            lekarzZdjecie.Data = S.GetBytes(zdjecie);
                        await S.LekarzeZdjeciaService.Create(lekarzZdjecie); 
                    }

                    Cursor = Cursors.Default;
                    MessageBox.Show("Dane zostały dodane poprawnie");
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
                var zdjecie = (await S.LekarzeZdjeciaService.GetAll ())
                    .FirstOrDefault (f=> f.Nazwa == listBoxZdjecia.SelectedItem.ToString () && f.LekarzId == S.Lekarz.LekarzId);
                if (zdjecie != null)
                {
                    var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        await S.LekarzeZdjeciaService.Delete(zdjecie.LekarzZdjecieId);

                        var zdjecia = (await S.LekarzeZdjeciaService.GetAll())
                            .Where(w => w.LekarzId == S.Lekarz.LekarzId)
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
