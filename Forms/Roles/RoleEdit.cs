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

namespace WinFormsApp96.Forms.Roles
{
    public partial class RoleEdit : Form
    {
        public RoleEdit ()
        {
            InitializeComponent();
        }

        private async void RoleEdit_Load (object sender, EventArgs e)
        {
            S.Role = await S.RolesService.Get (S.RoleId);
            if (S.Role != null)
            {
                textBoxNazwa.Text = S.Role.Name;
            }
        }
        
        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (S.IsValid(new List<TextBox>() { textBoxNazwa }))
                {

                    S.Role.Name = textBoxNazwa.Text;
                    await S.RolesService.Edit(S.Role.Id, S.Role);


                    Cursor = Cursors.Default;
                    MessageBox.Show("Dane zostały dodane prawidłowo");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wszystkie pola muszą być wypełnione poprawnie");
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
