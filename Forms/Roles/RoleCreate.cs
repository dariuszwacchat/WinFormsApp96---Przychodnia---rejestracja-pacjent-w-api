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
    public partial class RoleCreate : Form
    {
        public RoleCreate ()
        {
            InitializeComponent();
        }

        private void RoleCreate_Load (object sender, EventArgs e)
        {

        }

        private async void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (S.IsValid(new List<TextBox>() { textBoxNazwa }))
                {
                    ApplicationRole role = new ApplicationRole ()
                    {
                        Id = Guid.NewGuid ().ToString (), 
                        ConcurrencyStamp = Guid.NewGuid ().ToString (),
                        Name = textBoxNazwa.Text,
                        NormalizedName = textBoxNazwa.Text.ToUpper ()
                    };
                    await S.RolesService.Create(role);


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
