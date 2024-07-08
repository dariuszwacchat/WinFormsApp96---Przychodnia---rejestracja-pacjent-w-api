
namespace WinFormsApp95.Forms.Personel
{
    partial class UserCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.buttonUsunZdjecie = new System.Windows.Forms.Button();
            this.buttonDodajZdjecie = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.listBoxZdjecia = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMiejscowosc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUwagi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelUprawnienia = new System.Windows.Forms.Panel();
            this.dateTimePickerDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUsunZdjecie
            // 
            this.buttonUsunZdjecie.Location = new System.Drawing.Point(333, 581);
            this.buttonUsunZdjecie.Name = "buttonUsunZdjecie";
            this.buttonUsunZdjecie.Size = new System.Drawing.Size(107, 40);
            this.buttonUsunZdjecie.TabIndex = 49;
            this.buttonUsunZdjecie.Text = "Usuń";
            this.buttonUsunZdjecie.UseVisualStyleBackColor = true;
            this.buttonUsunZdjecie.Click += new System.EventHandler(this.buttonUsunZdjecie_Click);
            // 
            // buttonDodajZdjecie
            // 
            this.buttonDodajZdjecie.Location = new System.Drawing.Point(220, 581);
            this.buttonDodajZdjecie.Name = "buttonDodajZdjecie";
            this.buttonDodajZdjecie.Size = new System.Drawing.Size(107, 40);
            this.buttonDodajZdjecie.TabIndex = 48;
            this.buttonDodajZdjecie.Text = "Dodaj";
            this.buttonDodajZdjecie.UseVisualStyleBackColor = true;
            this.buttonDodajZdjecie.Click += new System.EventHandler(this.buttonDodajZdjecie_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonZapisz.FlatAppearance.BorderSize = 0;
            this.buttonZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZapisz.Location = new System.Drawing.Point(12, 22);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(197, 57);
            this.buttonZapisz.TabIndex = 3;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = false;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // listBoxZdjecia
            // 
            this.listBoxZdjecia.FormattingEnabled = true;
            this.listBoxZdjecia.ItemHeight = 30;
            this.listBoxZdjecia.Location = new System.Drawing.Point(44, 451);
            this.listBoxZdjecia.Name = "listBoxZdjecia";
            this.listBoxZdjecia.ScrollAlwaysVisible = true;
            this.listBoxZdjecia.Size = new System.Drawing.Size(396, 124);
            this.listBoxZdjecia.TabIndex = 47;
            this.listBoxZdjecia.SelectedIndexChanged += new System.EventHandler(this.listBoxZdjecia_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 306);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 100);
            this.panel1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(483, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dodawanie nowego pracownika";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 738);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1314, 100);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonZamknij);
            this.panel3.Controls.Add(this.buttonZapisz);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(852, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 100);
            this.panel3.TabIndex = 0;
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonZamknij.FlatAppearance.BorderSize = 0;
            this.buttonZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamknij.Location = new System.Drawing.Point(234, 22);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(197, 57);
            this.buttonZamknij.TabIndex = 2;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = false;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 30);
            this.label9.TabIndex = 37;
            this.label9.Text = "Uwagi";
            // 
            // textBoxMiejscowosc
            // 
            this.textBoxMiejscowosc.Location = new System.Drawing.Point(738, 303);
            this.textBoxMiejscowosc.Name = "textBoxMiejscowosc";
            this.textBoxMiejscowosc.Size = new System.Drawing.Size(514, 35);
            this.textBoxMiejscowosc.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 30);
            this.label8.TabIndex = 38;
            this.label8.Text = "Miejscowość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 30);
            this.label6.TabIndex = 39;
            this.label6.Text = "Data urodzenia";
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(738, 262);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(514, 35);
            this.textBoxPesel.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 30);
            this.label5.TabIndex = 36;
            this.label5.Text = "Pesel";
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Location = new System.Drawing.Point(738, 221);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(514, 35);
            this.textBoxUlica.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ulica";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(738, 180);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(514, 35);
            this.textBoxNazwisko.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nazwisko";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(738, 139);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(514, 35);
            this.textBoxImie.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 33;
            this.label1.Text = "Imię";
            // 
            // textBoxUwagi
            // 
            this.textBoxUwagi.Location = new System.Drawing.Point(738, 426);
            this.textBoxUwagi.Multiline = true;
            this.textBoxUwagi.Name = "textBoxUwagi";
            this.textBoxUwagi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUwagi.Size = new System.Drawing.Size(514, 109);
            this.textBoxUwagi.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 30);
            this.label7.TabIndex = 37;
            this.label7.Text = "Uprawnienia";
            // 
            // panelUprawnienia
            // 
            this.panelUprawnienia.AutoScroll = true;
            this.panelUprawnienia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUprawnienia.Location = new System.Drawing.Point(738, 554);
            this.panelUprawnienia.Name = "panelUprawnienia";
            this.panelUprawnienia.Size = new System.Drawing.Size(514, 140);
            this.panelUprawnienia.TabIndex = 66;
            // 
            // dateTimePickerDataUrodzenia
            // 
            this.dateTimePickerDataUrodzenia.Location = new System.Drawing.Point(738, 344);
            this.dateTimePickerDataUrodzenia.Name = "dateTimePickerDataUrodzenia";
            this.dateTimePickerDataUrodzenia.Size = new System.Drawing.Size(514, 35);
            this.dateTimePickerDataUrodzenia.TabIndex = 67;
            // 
            // UserCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 838);
            this.Controls.Add(this.dateTimePickerDataUrodzenia);
            this.Controls.Add(this.panelUprawnienia);
            this.Controls.Add(this.textBoxUwagi);
            this.Controls.Add(this.buttonUsunZdjecie);
            this.Controls.Add(this.buttonDodajZdjecie);
            this.Controls.Add(this.listBoxZdjecia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxMiejscowosc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUlica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.label1);
            this.Name = "UserCreate";
            this.Text = "Dodawanie nowego pracownika";
            this.Load += new System.EventHandler(this.UserCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUsunZdjecie;
        private System.Windows.Forms.Button buttonDodajZdjecie;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.ListBox listBoxZdjecia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMiejscowosc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUwagi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelUprawnienia;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataUrodzenia;
    }
}