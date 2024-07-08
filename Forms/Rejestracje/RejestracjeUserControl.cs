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

namespace WinFormsApp96.Forms.Rejestracje
{
    public partial class RejestracjeUserControl : UserControl
    {
        public RejestracjeUserControl ()
        {
            InitializeComponent(); 
            S.Index = 1;
            DisplayRejestracje ();
            S.SetDataGridViewStyles2 (dataGridViewRejestracje);
        }

        private async void DisplayRejestracje ()
        {
            S.Index = 1;
            try
            {
                var rejestracje = await S.RejestracjeService.GetAll ();
                List <object> rejestracjeLista = new List<object> ();
                for (var i=0; i< rejestracje.Count; i++)
                {
                    Rejestracja rejestracja = rejestracje [i];
                    var lekarz = (await S.LekarzeService.GetAll ())
                            .FirstOrDefault (f=> f.LekarzId == rejestracja.LekarzId);

                    var pacjent = (await S.PacjenciService.GetAll ())
                            .FirstOrDefault (f=> f.PacjentId == rejestracja.PacjentId);

                    rejestracjeLista.Add(new
                    {
                        RejestracjaId = rejestracja.RejestracjaId,
                        Lp = i+1,
                        DataRejestracji = rejestracja.DataRejestracji.ToShortDateString(),
                        NaKiedy = rejestracja.NaKiedy,
                        Gabinet = rejestracja.Gabinet,
                        NumerRejestracji = rejestracja.NumerRejestracji,
                        Lekarz = $"{lekarz.Imie} {lekarz.Nazwisko}",
                        Pacjent = $"{pacjent.Imie} {pacjent.Nazwisko}"
                    });
                } 
                dataGridViewRejestracje.DataSource = rejestracjeLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            } 
        }

        private void toolStripButtonDodaj_Click (object sender, EventArgs e)
        {
            CreateRejestracja cr = new CreateRejestracja ();
            cr.ShowDialog ();
        }

        private async void toolStripButtonUsun_Click (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(S.RejestracjaId))
                {
                    var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        await S.RejestracjeService.Delete(S.RejestracjaId);
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
            EditRejestracja er = new EditRejestracja ();
            er.ShowDialog ();
        }

        private void dataGridViewRejestracje_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    S.RejestracjaId = dataGridViewRejestracje.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewRejestracje_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRejestracje.SelectedRows.Count > 0)
                    S.RejestracjaId = dataGridViewRejestracje.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }
    }
}
