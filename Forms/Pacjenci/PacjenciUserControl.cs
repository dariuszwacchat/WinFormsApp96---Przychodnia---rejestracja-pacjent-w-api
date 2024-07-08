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

namespace WinFormsApp96.Forms.Pacjenci
{
    public partial class PacjenciUserControl : UserControl
    {
        public PacjenciUserControl ()
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
                List <object> pacjenciLista = new List<object> ();
                foreach (Pacjent pacjent in pacjenci)
                {
                    var rejestracje = (await S.RejestracjeService.GetAll ())
                            .Where (w=> w.PacjentId == pacjent.PacjentId)
                            .ToList ();

                    pacjenciLista.Add(new
                    {
                        PacjentId = pacjent.PacjentId,
                        Lp = S.Index,
                        Imie = pacjent.Imie,
                        Nazwisko = pacjent.Nazwisko,
                        Ulica = pacjent.Ulica,
                        Pesel = pacjent.Pesel,
                        Miejscowosc = pacjent.Miejscowosc,
                        DataUrodzenia = pacjent.DataUrodzenia.ToShortDateString(),
                        Rejestracje = rejestracje.Count
                    });
                    S.Index++;
                }
                dataGridViewPacjeci.DataSource = pacjenciLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void toolStripButtonDodaj_Click (object sender, EventArgs e)
        {
            CreatePacjent cp = new CreatePacjent ();
            cp.Show ();
        }

        private async void toolStripButtonUsun_Click (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(S.PacjentId))
                {
                    var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.Yes)
                    {
                        await S.PacjenciService.Delete(S.PacjentId);
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
            EditPacjent ep = new EditPacjent();
            ep.ShowDialog ();
        }

        private void dataGridViewPacjeci_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    S.PacjentId = dataGridViewPacjeci.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            }
            catch { }
        }

        private void dataGridViewPacjeci_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPacjeci.SelectedRows.Count > 0)
                    S.PacjentId = dataGridViewPacjeci.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }
    }
}
