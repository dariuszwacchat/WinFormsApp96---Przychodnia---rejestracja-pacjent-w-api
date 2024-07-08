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

namespace WinFormsApp96.Forms.RejestratorPrac
{
    public partial class RejestratorPracUserControl : UserControl
    {
        public RejestratorPracUserControl ()
        {
            InitializeComponent();

            DisplayRejestratorPrac ();
            S.SetDataGridViewStyles2 (dataGridViewRejestratorPrac);
        }

        private async void DisplayRejestratorPrac ()
        {
            try
            {
                S.Index = 0;
                var rejestratorPrac = await S.RejestratorPracyService.GetAll ();
                dataGridViewRejestratorPrac.DataSource = (from f in rejestratorPrac
                                                          select new
                                                          {
                                                              RejestratorPracyId = f.RejestratorPracyId,
                                                              Lp = S.IndexCounter,
                                                              DataZalogowania = f.DataZalogowania,
                                                              DataWylogowania = f.DataWylogowania,
                                                              //UserId = f.UserId, 
                                                          }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            } 
        }

        private void toolStripButtonDodaj_Click (object sender, EventArgs e)
        {
            RejestratorPracyCreate rpc = new RejestratorPracyCreate ();
            rpc.ShowDialog ();
        }

        private async void toolStripButtonUsun_Click (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(S.RejestratorPracyId))
                {
                    var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        await S.RejestratorPracyService.Delete(S.RejestratorPracyId);
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
            RejestratorPracyEdit rpe = new RejestratorPracyEdit ();
            rpe.ShowDialog ();
        }

        private void dataGridViewRejestratorPrac_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    S.RejestratorPracyId = dataGridViewRejestratorPrac.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewRejestratorPrac_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRejestratorPrac.SelectedRows.Count > 0)
                    S.RejestratorPracyId = dataGridViewRejestratorPrac.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }
    }
}
