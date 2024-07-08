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
    public partial class RejestratorPracyEdit : Form
    {
        public RejestratorPracyEdit ()
        {
            InitializeComponent();
        }

        private async void RejestratorPracyEdit_Load (object sender, EventArgs e)
        {
            try
            {
                S.RejestratorPracy = await S.RejestratorPracyService.Get(S.RejestratorPracyId);
                if (S.RejestratorPracy != null)
                {
                    /*var user = await S.UsersService.GetUserById (S.RejestratorPracy.UserId);
                    if (user != null)
                        comboBoxUsers.Text = user.Nazwisko;*/

                    dateTimePickerDataZalogowania.Value = S.RejestratorPracy.DataZalogowania;
                    dateTimePickerDataWylogowania.Value = S.RejestratorPracy.DataWylogowania;

                    textBox1.Text = S.RejestratorPracy.DataZalogowania.ToShortTimeString();
                    textBox2.Text = S.RejestratorPracy.DataWylogowania.ToShortTimeString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (S.IsValid(new List<TextBox>() { textBox1, textBox2 }))
                {
                    TimeSpan gz = TimeSpan.Parse(textBox1.Text);
                    DateTime dz = dateTimePickerDataZalogowania.Value;
                    DateTime dataZalogowania = new DateTime (dz.Year, dz.Month, dz.Day, gz.Hours, gz.Minutes, gz.Seconds);

                    TimeSpan gw = TimeSpan.Parse(textBox2.Text);
                    DateTime dw = dateTimePickerDataWylogowania.Value;
                    DateTime dataWylogowania = new DateTime (dw.Year, dw.Month, dw.Day, gw.Hours, gw.Minutes, gw.Seconds);
                     

                    S.RejestratorPracy.DataZalogowania = dataZalogowania;
                    S.RejestratorPracy.DataWylogowania = dataWylogowania;
                     

                    await S.RejestratorPracyService.Edit(S.RejestratorPracy.RejestratorPracyId, S.RejestratorPracy);

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
    }
}
