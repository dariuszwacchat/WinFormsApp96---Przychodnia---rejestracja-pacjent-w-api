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
    public partial class LekarzeUserControl : UserControl
    {
        public LekarzeUserControl ()
        {
            InitializeComponent();
            DisplayLekarze();
            S.SetDataGridViewStyles2(dataGridViewLekarze);
        }

        private void LekarzeUserControl_Load (object sender, EventArgs e)
        {
        }

        private async void DisplayLekarze ()
        {
            try
            {
                S.Index = 0;
                var lekarze = await S.LekarzeService.GetAll (); 
                List <object> items = new List<object> (); 
                foreach (Lekarz lekarz in lekarze)
                {
                    var rejestracje = (await S.RejestracjeService.GetAll ())
                            .Where (w=> w.LekarzId == lekarz.LekarzId)
                            .ToList ();

                    var pacjenci = (await S.PacjenciService.GetAll ())
                            .Where (w=> w.LekarzId == lekarz.LekarzId)
                            .ToList ();

                    items.Add (new
                    {
                        LekarzId = lekarz.LekarzId,
                        Lp = S.Index,
                        Imie = lekarz.Imie,
                        Nazwisko = lekarz.Nazwisko,
                        Ulica = lekarz.Ulica,
                        Pesel = lekarz.Pesel,
                        Miejscowosc = lekarz.Miejscowosc,
                        DataUrodzenia = lekarz.DataUrodzenia.ToShortDateString (),
                        Rejestracje = rejestracje.Count,
                        Pacjenci = pacjenci.Count
                    });
                    S.Index++;
                }  
                dataGridViewLekarze.DataSource = items;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }




        private void toolStripButtonDodaj_Click (object sender, EventArgs e)
        {
            LekarzCreate lc = new LekarzCreate ();
            lc.ShowDialog();
        }

        private async void toolStripButtonUsun_Click (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(S.LekarzId))
                {
                    var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        await S.LekarzeService.Delete(S.LekarzId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonModyfikuj_Click (object sender, EventArgs e)
        {
            LekarzEdit le = new LekarzEdit ();
            le.ShowDialog();
        }

        private void dataGridViewLekarze_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    S.LekarzId = dataGridViewLekarze.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewLekarze_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewLekarze.SelectedRows.Count > 0)
                    S.LekarzId = dataGridViewLekarze.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

    }
}
