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

namespace WinFormsApp96.Forms.Roles
{
    public partial class RolesUserControl : UserControl
    {
        public RolesUserControl ()
        {
            InitializeComponent();

            DisplayRoles ();
            S.SetDataGridViewStyles2 (dataGridViewRoles);
        }

        private async void DisplayRoles ()
        {
            try
            {
                S.Index = 0;
                var roles = await S.RolesService.GetAll ();
                dataGridViewRoles.DataSource = (from f in roles
                                                select new
                                                {
                                                    Id = f.Id,
                                                    Lp = S.IndexCounter,
                                                    Name = f.Name,
                                                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            } 
        }

        private void toolStripButtonDodaj_Click (object sender, EventArgs e)
        {
            RoleCreate rc = new RoleCreate ();
            rc.ShowDialog ();
        }

        private async void toolStripButtonUsun_Click (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(S.RoleId))
                {
                    var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        await S.RolesService.Delete(S.RoleId);
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
            RoleEdit re = new RoleEdit ();
            re.ShowDialog ();
        }

        private void dataGridViewRoles_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    S.RoleId = dataGridViewRoles.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewRoles_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRoles.SelectedRows.Count > 0)
                    S.RoleId = dataGridViewRoles.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }
    }
}
