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

namespace WinFormsApp95.Forms.Personel
{
    public partial class PersonelUserControl : UserControl
    {
        public PersonelUserControl ()
        {
            InitializeComponent();

            S.SetDataGridViewStyles2(dataGridViewPersonel);
            DisplayPersonel ();
        }

        private async void DisplayPersonel ()
        {
            try
            {
                S.Index = 0;
                var users = await S.UsersService.GetAll ();
                dataGridViewPersonel.DataSource = (from f in users
                                                   select new
                                                   {
                                                       Id = f.Id,
                                                       Lp = S.IndexCounter,
                                                       Imie = f.Imie,
                                                       Nazwisko = f.Nazwisko,
                                                       Ulica = f.Ulica,
                                                       Pesel = f.Pesel,
                                                       Miejscowosc = f.Miejscowosc,
                                                       ZatrudnionyOd = f.ZatrudnionyOd.ToShortDateString()
                                                   }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }


        private void toolStripButtonDodaj_Click (object sender, EventArgs e)
        {
            UserCreate uc = new UserCreate ();
            uc.ShowDialog ();
        }

        private async void toolStripButtonUsun_Click (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(S.UserId))
                {
                    var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        await S.UsersService.Delete(S.UserId);
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
            if (!string.IsNullOrEmpty(S.UserId))
            {
                UserEdit ue = new UserEdit ();
                ue.ShowDialog ();
            }
        }

        private void dataGridViewPersonel_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    S.UserId = dataGridViewPersonel.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewPersonel_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPersonel.SelectedRows.Count > 0)
                    S.UserId = dataGridViewPersonel.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }
    }
}
