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
using WinFormsApp95.Forms;
using WinFormsApp95.Forms.Personel;
using WinFormsApp96.Forms.Lekarze;
using WinFormsApp96.Forms.Pacjenci;
using WinFormsApp96.Forms.Rejestracje;
using WinFormsApp96.Forms.RejestratorPrac;
using WinFormsApp96.Forms.Roles;
using WinFormsApp96.Forms.Specjalizacje;
using WinFormsApp96.Services;

namespace WinFormsApp96
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();

            S.SetColors(panelNavigationMain);
            S.SetColor(panelNavigationMain);

            S.ClearPanelContainer(panelContainerMain);
            RejestracjeUserControl rejestracjeUserControl = new RejestracjeUserControl ();
            rejestracjeUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(rejestracjeUserControl);
            buttonRejestracje.BackColor = Color.FromArgb(180, 180, 180);
            buttonRejestracje.ForeColor = Color.Black;

            if (S.ZalogowanyUser != null)
                toolStripStatusLabelZalogowanyUzytkownik.Text = $"Zalogowany użytkownik: {S.ZalogowanyUser.Email}";
        }

        private async void Form1_Load (object sender, EventArgs e)
        {  
            if (await S.LoggedUserInRole("Personel"))
            {
                buttonRejestratorPracy.Visible = false;
                buttonRole.Visible = false;
                buttonSpecjalizacje.Visible = false;
            }
        }



        private void buttonRejestracje_Click (object sender, EventArgs e)
        { 
            S.ClearPanelContainer(panelContainerMain);
            RejestracjeUserControl rejestracjeUserControl = new RejestracjeUserControl ();
            rejestracjeUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(rejestracjeUserControl);
        }

        private void buttonLekarze_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            LekarzeUserControl lekarzeUserControl = new LekarzeUserControl ();
            lekarzeUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(lekarzeUserControl);
        }

        private void buttonPacjenci_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            PacjenciUserControl pacjenciUserControl = new PacjenciUserControl ();
            pacjenciUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(pacjenciUserControl);
        }

        private void buttonPersonel_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            PersonelUserControl personelUserControl = new PersonelUserControl ();
            personelUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(personelUserControl);
        }

        private void buttonRole_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            RolesUserControl rolesUserControl = new RolesUserControl ();
            rolesUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(rolesUserControl);
        }

        private void buttonSpecjalizacje_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            SpecjalizacjeUserControl specjalizacjeUserControl = new SpecjalizacjeUserControl ();
            specjalizacjeUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(specjalizacjeUserControl);
        }

        private void buttonRejestratorPracy_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainerMain);
            RejestratorPracUserControl rejestratorPracUserControl = new RejestratorPracUserControl ();
            rejestratorPracUserControl.Dock = DockStyle.Fill;
            panelContainerMain.Controls.Add(rejestratorPracUserControl);
        }

        private void buttonWyjscie_Click (object sender, EventArgs e)
        {
            RejestratorPracyWylogowanie ();
            Close ();
        }


        private async void RejestratorPracyWylogowanie ()
        {
            /*S.RejestratorPracy = (await S.RejestratorPracyService.GetAll())
                   .OrderByDescending(o => o.DataZalogowania)
                   .FirstOrDefault(f => f.UserId == S.ZalogowanyUser.Id);
            if (S.RejestratorPracy != null)
            {
                DateTime now = DateTime.Now;
                var czasPracy = now - S.RejestratorPracy.DataZalogowania;

                S.RejestratorPracy.DataWylogowania = DateTime.Now;
                S.RejestratorPracy.CzasPracy = new TimeSpan(czasPracy.Hours, czasPracy.Minutes, czasPracy.Seconds);
                await S.RejestratorPracyService.Edit(S.RejestratorPracy.RejestratorPracyId, S.RejestratorPracy);
            }*/
        }

        private void wylogujToolStripMenuItem_Click (object sender, EventArgs e)
        {
            RejestratorPracyWylogowanie ();
        }

        private void zamknijToolStripMenuItem_Click (object sender, EventArgs e)
        {
            RejestratorPracyWylogowanie ();
        }
    }
}
