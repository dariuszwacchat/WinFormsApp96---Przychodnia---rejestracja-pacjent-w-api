
namespace WinFormsApp96
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.panelNavigationMain = new System.Windows.Forms.Panel();
            this.buttonRole = new System.Windows.Forms.Button();
            this.buttonPersonel = new System.Windows.Forms.Button();
            this.buttonLekarze = new System.Windows.Forms.Button();
            this.buttonWyjscie = new System.Windows.Forms.Button();
            this.buttonSpecjalizacje = new System.Windows.Forms.Button();
            this.buttonRejestratorPracy = new System.Windows.Forms.Button();
            this.buttonPacjenci = new System.Windows.Forms.Button();
            this.buttonRejestracje = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainerMain = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelZalogowanyUzytkownik = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelNavigationMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigationMain
            // 
            this.panelNavigationMain.AutoScroll = true;
            this.panelNavigationMain.BackColor = System.Drawing.Color.Transparent;
            this.panelNavigationMain.Controls.Add(this.buttonRole);
            this.panelNavigationMain.Controls.Add(this.buttonPersonel);
            this.panelNavigationMain.Controls.Add(this.buttonLekarze);
            this.panelNavigationMain.Controls.Add(this.buttonWyjscie);
            this.panelNavigationMain.Controls.Add(this.buttonSpecjalizacje);
            this.panelNavigationMain.Controls.Add(this.buttonRejestratorPracy);
            this.panelNavigationMain.Controls.Add(this.buttonPacjenci);
            this.panelNavigationMain.Controls.Add(this.buttonRejestracje);
            this.panelNavigationMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigationMain.Location = new System.Drawing.Point(0, 38);
            this.panelNavigationMain.Name = "panelNavigationMain";
            this.panelNavigationMain.Size = new System.Drawing.Size(348, 525);
            this.panelNavigationMain.TabIndex = 13;
            // 
            // buttonRole
            // 
            this.buttonRole.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRole.FlatAppearance.BorderSize = 0;
            this.buttonRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRole.ForeColor = System.Drawing.Color.Black;
            this.buttonRole.Location = new System.Drawing.Point(14, 255);
            this.buttonRole.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRole.Name = "buttonRole";
            this.buttonRole.Size = new System.Drawing.Size(320, 50);
            this.buttonRole.TabIndex = 0;
            this.buttonRole.Text = "Role";
            this.buttonRole.UseVisualStyleBackColor = false;
            this.buttonRole.Click += new System.EventHandler(this.buttonRole_Click);
            // 
            // buttonPersonel
            // 
            this.buttonPersonel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPersonel.FlatAppearance.BorderSize = 0;
            this.buttonPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPersonel.ForeColor = System.Drawing.Color.Black;
            this.buttonPersonel.Location = new System.Drawing.Point(14, 204);
            this.buttonPersonel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPersonel.Name = "buttonPersonel";
            this.buttonPersonel.Size = new System.Drawing.Size(320, 50);
            this.buttonPersonel.TabIndex = 0;
            this.buttonPersonel.Text = "Personel";
            this.buttonPersonel.UseVisualStyleBackColor = false;
            this.buttonPersonel.Click += new System.EventHandler(this.buttonPersonel_Click);
            // 
            // buttonLekarze
            // 
            this.buttonLekarze.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLekarze.FlatAppearance.BorderSize = 0;
            this.buttonLekarze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLekarze.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLekarze.ForeColor = System.Drawing.Color.Black;
            this.buttonLekarze.Location = new System.Drawing.Point(14, 102);
            this.buttonLekarze.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLekarze.Name = "buttonLekarze";
            this.buttonLekarze.Size = new System.Drawing.Size(320, 50);
            this.buttonLekarze.TabIndex = 0;
            this.buttonLekarze.Text = "Lekarze";
            this.buttonLekarze.UseVisualStyleBackColor = false;
            this.buttonLekarze.Click += new System.EventHandler(this.buttonLekarze_Click);
            // 
            // buttonWyjscie
            // 
            this.buttonWyjscie.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonWyjscie.FlatAppearance.BorderSize = 0;
            this.buttonWyjscie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyjscie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWyjscie.ForeColor = System.Drawing.Color.Black;
            this.buttonWyjscie.Location = new System.Drawing.Point(14, 408);
            this.buttonWyjscie.Margin = new System.Windows.Forms.Padding(0);
            this.buttonWyjscie.Name = "buttonWyjscie";
            this.buttonWyjscie.Size = new System.Drawing.Size(320, 50);
            this.buttonWyjscie.TabIndex = 0;
            this.buttonWyjscie.Text = "Wyjście";
            this.buttonWyjscie.UseVisualStyleBackColor = false;
            this.buttonWyjscie.Click += new System.EventHandler(this.buttonWyjscie_Click);
            // 
            // buttonSpecjalizacje
            // 
            this.buttonSpecjalizacje.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSpecjalizacje.FlatAppearance.BorderSize = 0;
            this.buttonSpecjalizacje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpecjalizacje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSpecjalizacje.ForeColor = System.Drawing.Color.Black;
            this.buttonSpecjalizacje.Location = new System.Drawing.Point(14, 306);
            this.buttonSpecjalizacje.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSpecjalizacje.Name = "buttonSpecjalizacje";
            this.buttonSpecjalizacje.Size = new System.Drawing.Size(320, 50);
            this.buttonSpecjalizacje.TabIndex = 0;
            this.buttonSpecjalizacje.Text = "Specjalizacje";
            this.buttonSpecjalizacje.UseVisualStyleBackColor = false;
            this.buttonSpecjalizacje.Click += new System.EventHandler(this.buttonSpecjalizacje_Click);
            // 
            // buttonRejestratorPracy
            // 
            this.buttonRejestratorPracy.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRejestratorPracy.FlatAppearance.BorderSize = 0;
            this.buttonRejestratorPracy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRejestratorPracy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRejestratorPracy.ForeColor = System.Drawing.Color.Black;
            this.buttonRejestratorPracy.Location = new System.Drawing.Point(14, 357);
            this.buttonRejestratorPracy.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRejestratorPracy.Name = "buttonRejestratorPracy";
            this.buttonRejestratorPracy.Size = new System.Drawing.Size(320, 50);
            this.buttonRejestratorPracy.TabIndex = 0;
            this.buttonRejestratorPracy.Text = "Rejestrator pracy";
            this.buttonRejestratorPracy.UseVisualStyleBackColor = false;
            this.buttonRejestratorPracy.Click += new System.EventHandler(this.buttonRejestratorPracy_Click);
            // 
            // buttonPacjenci
            // 
            this.buttonPacjenci.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPacjenci.FlatAppearance.BorderSize = 0;
            this.buttonPacjenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPacjenci.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPacjenci.ForeColor = System.Drawing.Color.Black;
            this.buttonPacjenci.Location = new System.Drawing.Point(14, 153);
            this.buttonPacjenci.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPacjenci.Name = "buttonPacjenci";
            this.buttonPacjenci.Size = new System.Drawing.Size(320, 50);
            this.buttonPacjenci.TabIndex = 0;
            this.buttonPacjenci.Text = "Pacjenci";
            this.buttonPacjenci.UseVisualStyleBackColor = false;
            this.buttonPacjenci.Click += new System.EventHandler(this.buttonPacjenci_Click);
            // 
            // buttonRejestracje
            // 
            this.buttonRejestracje.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonRejestracje.FlatAppearance.BorderSize = 0;
            this.buttonRejestracje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRejestracje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRejestracje.ForeColor = System.Drawing.Color.Black;
            this.buttonRejestracje.Location = new System.Drawing.Point(14, 51);
            this.buttonRejestracje.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRejestracje.Name = "buttonRejestracje";
            this.buttonRejestracje.Size = new System.Drawing.Size(320, 50);
            this.buttonRejestracje.TabIndex = 0;
            this.buttonRejestracje.Text = "Rejestracje";
            this.buttonRejestracje.UseVisualStyleBackColor = false;
            this.buttonRejestracje.Click += new System.EventHandler(this.buttonRejestracje_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 38);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(63, 34);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.wylogujToolStripMenuItem.Text = "&Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.zamknijToolStripMenuItem.Text = "&Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // panelContainerMain
            // 
            this.panelContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerMain.Location = new System.Drawing.Point(348, 38);
            this.panelContainerMain.Name = "panelContainerMain";
            this.panelContainerMain.Size = new System.Drawing.Size(824, 525);
            this.panelContainerMain.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelZalogowanyUzytkownik});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1172, 39);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelZalogowanyUzytkownik
            // 
            this.toolStripStatusLabelZalogowanyUzytkownik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStatusLabelZalogowanyUzytkownik.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelZalogowanyUzytkownik.Name = "toolStripStatusLabelZalogowanyUzytkownik";
            this.toolStripStatusLabelZalogowanyUzytkownik.Size = new System.Drawing.Size(206, 30);
            this.toolStripStatusLabelZalogowanyUzytkownik.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1172, 602);
            this.Controls.Add(this.panelContainerMain);
            this.Controls.Add(this.panelNavigationMain);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Przychodnia - rejestracja pacjentów";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelNavigationMain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigationMain;
        private System.Windows.Forms.Button buttonRole;
        private System.Windows.Forms.Button buttonPersonel;
        private System.Windows.Forms.Button buttonLekarze;
        private System.Windows.Forms.Button buttonWyjscie;
        private System.Windows.Forms.Button buttonSpecjalizacje;
        private System.Windows.Forms.Button buttonRejestratorPracy;
        private System.Windows.Forms.Button buttonPacjenci;
        private System.Windows.Forms.Button buttonRejestracje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainerMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelZalogowanyUzytkownik;
    }
}

