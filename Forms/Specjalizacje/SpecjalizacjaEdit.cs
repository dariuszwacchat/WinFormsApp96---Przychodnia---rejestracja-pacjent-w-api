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

namespace WinFormsApp96.Forms.Specjalizacje
{
    public partial class SpecjalizacjaEdit : Form
    {
        public SpecjalizacjaEdit ()
        {
            InitializeComponent();
        }

        private async void SpecjalizacjaEdit_Load (object sender, EventArgs e)
        {
            S.Specjalizacja = await S.SpecjalizacjeService.Get (S.SpecjalizacjaId);
            if (S.Specjalizacja != null)
            {
                textBoxNazwa.Text = S.Specjalizacja.Nazwa;
            }
        }

        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                if (S.Specjalizacja != null)
                {
                    Cursor = Cursors.WaitCursor;

                    if (S.IsValid(new List<TextBox>() { textBoxNazwa }))
                    {
                        S.Specjalizacja.Nazwa = textBoxNazwa.Text;

                        await S.SpecjalizacjeService.Edit(S.Specjalizacja.SpecjalizacjaId, S.Specjalizacja);
                    }
                    else
                    {
                        MessageBox.Show("Wszystkie pola muszą być wypełnione poprawnie");
                    }

                    Cursor = Cursors.Default;
                    MessageBox.Show("Dane został dodane");
                    Close();
                }
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
    }
}
