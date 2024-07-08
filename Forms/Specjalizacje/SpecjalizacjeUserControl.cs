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
    public partial class SpecjalizacjeUserControl : UserControl
    {
        public SpecjalizacjeUserControl ()
        {
            InitializeComponent();
            
            DisplaySpecjalizacje ();
            S.SetDataGridViewStyles2 (dataGridViewSpecjalizacje);
        }

        private async void DisplaySpecjalizacje ()
        {
            try
            {
                S.Index = 0;
                var specjalizacje = await S.SpecjalizacjeService.GetAll ();
                dataGridViewSpecjalizacje.DataSource = (from f in specjalizacje
                                                        select new
                                                        {
                                                            SpecjalizacjaId = f.SpecjalizacjaId,
                                                            Lp = S.IndexCounter,
                                                            Nazwa = f.Nazwa
                                                        }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            } 
        }

        private void toolStripButtonDodaj_Click (object sender, EventArgs e)
        {
            SpecjalizacjaCreate sc = new SpecjalizacjaCreate ();
            sc.ShowDialog ();
        }

        private async void toolStripButtonUsun_Click (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(S.SpecjalizacjaId))
                {
                    var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        await S.SpecjalizacjeService.Delete(S.SpecjalizacjaId);
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
            SpecjalizacjaEdit se = new SpecjalizacjaEdit ();
            se.ShowDialog ();
        }

        private void dataGridViewSpecjalizacje_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    S.SpecjalizacjaId = dataGridViewSpecjalizacje.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewSpecjalizacje_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSpecjalizacje.SelectedRows.Count > 0)
                    S.SpecjalizacjaId = dataGridViewSpecjalizacje.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }
    }
}
