using Domain;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp96;
using WinFormsApp96.Services;

namespace WinFormsApp95.Forms
{
    public partial class LoginForm : Form
    {
        private AccountService _accountService;
        public LoginForm ()
        {
            InitializeComponent();
            _accountService = new AccountService ();
        }

        private async void LoginForm_Load (object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                var users = (await S.UsersService.GetAll ())
                .Select (s=> s.Email)
                .ToList ();
                comboBoxUsers.DataSource = users;
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button1_Click (object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                LoginViewModel loginViewModel = new LoginViewModel ()
                {
                    Email = comboBoxUsers.SelectedItem.ToString (),
                    Password = textBoxHaslo.Text
                };
                var loginResult = await _accountService.Login (loginViewModel);

                if (loginResult.IsSuccessStatusCode)
                {
                    S.ZalogowanyUser = await S.UsersService.GetUserByEmail(loginViewModel.Email);


                    RejestratorPracy rejestratorPracy = new RejestratorPracy ()
                    {
                        RejestratorPracyId = Guid.NewGuid ().ToString (),
                        DataZalogowania = DateTime.Now,
                        DataWylogowania = DateTime.Now,
                        CzasPracy = new TimeSpan(3,2,1),
                        //UserId = S.ZalogowanyUser.Id 
                    };
                    await S.RejestratorPracyService.Create(rejestratorPracy);


                    Visible = false;
                    Form1 form = new Form1 ();
                    form.Show();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Błędny login lub hasło");
            }

            Cursor = Cursors.Default;
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close ();
        }

    }
}
