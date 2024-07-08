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

namespace WinFormsApp96.Forms.Specjalizacje
{
    public partial class SpecjalizacjaCreate : Form
    {
        public SpecjalizacjaCreate ()
        {
            InitializeComponent();
        }

        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (S.IsValid(new List<TextBox>() { textBoxNazwa }))
                {
                    Specjalizacja specjalizacja = new Specjalizacja ()
                    {
                        SpecjalizacjaId = Guid.NewGuid ().ToString (),
                        Nazwa = textBoxNazwa.Text
                    };
                    await S.SpecjalizacjeService.Create(specjalizacja);
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
         
    }
}
