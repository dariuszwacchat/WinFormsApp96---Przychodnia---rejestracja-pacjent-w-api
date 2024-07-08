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

namespace WinFormsApp96.Forms.RejestratorPrac
{
    public partial class RejestratorPracyCreate : Form
    {
        public RejestratorPracyCreate ()
        {
            InitializeComponent();
        }
        private async void RejestratorPracyCreate_Load (object sender, EventArgs e)
        { 
            comboBoxUsers.DataSource = (await S.UsersService.GetAll ())
                .Select (s=> s.Nazwisko)
                .ToList ();
        }

        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (S.IsValid (new List<TextBox> () { textBox1, textBox2 }))
                {
                    TimeSpan gz = TimeSpan.Parse(textBox1.Text);
                    DateTime dz = dateTimePickerDataZalogowania.Value;
                    DateTime dataZalogowania = new DateTime (dz.Year, dz.Month, dz.Day, gz.Hours, gz.Minutes, gz.Seconds);

                    TimeSpan gw = TimeSpan.Parse(textBox2.Text);
                    DateTime dw = dateTimePickerDataWylogowania.Value;
                    DateTime dataWylogowania = new DateTime (dw.Year, dw.Month, dw.Day, gw.Hours, gw.Minutes, gw.Seconds);

                    RejestratorPracy rejestratorPracy = new RejestratorPracy ()
                    {
                        RejestratorPracyId = Guid.NewGuid ().ToString (),
                        DataZalogowania = dataZalogowania,
                        DataWylogowania = dataWylogowania,
                    };
                    /*if (S.User != null)
                        rejestratorPracy.UserId = S.User.Id;*/

                    await S.RejestratorPracyService.Create(rejestratorPracy);

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

        private void textBox1_Click (object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox1.Text = "";
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {
        }

        private void textBox2_Click (object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
            textBox2.Text = "";
        }

        private async void comboBoxUsers_SelectedIndexChanged (object sender, EventArgs e)
        {
            S.User = (await S.UsersService.GetAll())
                .FirstOrDefault (f=> f.Nazwisko == comboBoxUsers.SelectedItem.ToString ());
        }
    }
}
