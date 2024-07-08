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
    public partial class PacjentSzukaj : Form
    {
        public PacjentSzukaj ()
        {
            InitializeComponent();
            DisplayPacjenci ();
            S.SetDataGridViewStyles2 (dataGridViewPacjeci);
        }

        private async void DisplayPacjenci ()
        {
            try
            {
                S.Index = 0;
                var pacjenci = await S.PacjenciService.GetAll ();

                if (!string.IsNullOrEmpty (textBox1.Text))
                    pacjenci = pacjenci.Where (w=> w.Nazwisko.Contains (textBox1.Text)).ToList ();


                dataGridViewPacjeci.DataSource = (from f in pacjenci
                                                  select new
                                                  {
                                                      PacjentId = f.PacjentId,
                                                      Lp = S.IndexCounter,
                                                      Imie = f.Imie,
                                                      Nazwisko = f.Nazwisko,
                                                      Pesel = f.Pesel,
                                                      Miejscowosc = f.Miejscowosc,
                                                      DataUrodzenia = f.DataUrodzenia
                                                  }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {
            DisplayPacjenci ();
        }

        private void dataGridViewPacjeci_CellMouseDoubleClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    S.PacjentId = dataGridViewPacjeci.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty (S.PacjentId))
                        Close ();
                } 
            }
            catch { }
        }

        private void buttonWybierz_Click (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPacjeci.SelectedRows.Count > 0)
                {
                    S.PacjentId = dataGridViewPacjeci.Rows[0].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(S.PacjentId))
                        Close();
                }
            }
            catch { }
        }

        private void buttonZamknij_Click (object sender, EventArgs e)
        {
            Close ();
        }

    }
}
