
namespace WinFormsApp96.Forms.Pacjenci
{
    partial class EditPacjent
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePickerDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.buttonUsunZdjecie = new System.Windows.Forms.Button();
            this.buttonDodajZdjecie = new System.Windows.Forms.Button();
            this.listBoxZdjecia = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUwagi = new System.Windows.Forms.TextBox();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewRejestracje = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxWizyty = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRejestracje)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(614, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "Edytowanie danych istniejącego pacjenta";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonZamknij);
            this.panel3.Controls.Add(this.buttonZapisz);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(957, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 100);
            this.panel3.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 735);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 100);
            this.panel2.TabIndex = 61;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(462, 374);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 198);
            this.panel5.TabIndex = 89;
            // 
            // dateTimePickerDataUrodzenia
            // 
            this.dateTimePickerDataUrodzenia.Location = new System.Drawing.Point(737, 243);
            this.dateTimePickerDataUrodzenia.Name = "dateTimePickerDataUrodzenia";
            this.dateTimePickerDataUrodzenia.Size = new System.Drawing.Size(514, 35);
            this.dateTimePickerDataUrodzenia.TabIndex = 88;
            // 
            // buttonUsunZdjecie
            // 
            this.buttonUsunZdjecie.Location = new System.Drawing.Point(332, 480);
            this.buttonUsunZdjecie.Name = "buttonUsunZdjecie";
            this.buttonUsunZdjecie.Size = new System.Drawing.Size(107, 40);
            this.buttonUsunZdjecie.TabIndex = 87;
            this.buttonUsunZdjecie.Text = "Usuń";
            this.buttonUsunZdjecie.UseVisualStyleBackColor = true;
            this.buttonUsunZdjecie.Click += new System.EventHandler(this.buttonUsunZdjecie_Click);
            // 
            // buttonDodajZdjecie
            // 
            this.buttonDodajZdjecie.Location = new System.Drawing.Point(219, 480);
            this.buttonDodajZdjecie.Name = "buttonDodajZdjecie";
            this.buttonDodajZdjecie.Size = new System.Drawing.Size(107, 40);
            this.buttonDodajZdjecie.TabIndex = 86;
            this.buttonDodajZdjecie.Text = "Dodaj";
            this.buttonDodajZdjecie.UseVisualStyleBackColor = true;
            this.buttonDodajZdjecie.Click += new System.EventHandler(this.buttonDodajZdjecie_Click);
            // 
            // listBoxZdjecia
            // 
            this.listBoxZdjecia.FormattingEnabled = true;
            this.listBoxZdjecia.ItemHeight = 30;
            this.listBoxZdjecia.Location = new System.Drawing.Point(43, 350);
            this.listBoxZdjecia.Name = "listBoxZdjecia";
            this.listBoxZdjecia.ScrollAlwaysVisible = true;
            this.listBoxZdjecia.Size = new System.Drawing.Size(396, 124);
            this.listBoxZdjecia.TabIndex = 85;
            this.listBoxZdjecia.SelectedIndexChanged += new System.EventHandler(this.listBoxZdjecia_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 306);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUwagi
            // 
            this.textBoxUwagi.Location = new System.Drawing.Point(737, 325);
            this.textBoxUwagi.Multiline = true;
            this.textBoxUwagi.Name = "textBoxUwagi";
            this.textBoxUwagi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUwagi.Size = new System.Drawing.Size(514, 184);
            this.textBoxUwagi.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 30);
            this.label9.TabIndex = 75;
            this.label9.Text = "Uwagi";
            // 
            // textBoxMiejscowosc
            // 
            this.textBoxMiejscowosc.Location = new System.Drawing.Point(737, 202);
            this.textBoxMiejscowosc.Name = "textBoxMiejscowosc";
            this.textBoxMiejscowosc.Size = new System.Drawing.Size(514, 35);
            this.textBoxMiejscowosc.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 30);
            this.label8.TabIndex = 76;
            this.label8.Text = "Miejscowość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 30);
            this.label6.TabIndex = 77;
            this.label6.Text = "Data urodzenia";
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(737, 161);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(514, 35);
            this.textBoxPesel.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 30);
            this.label5.TabIndex = 74;
            this.label5.Text = "Pesel";
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Location = new System.Drawing.Point(737, 120);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(514, 35);
            this.textBoxUlica.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 73;
            this.label3.Text = "Ulica";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(737, 79);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(514, 35);
            this.textBoxNazwisko.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 72;
            this.label2.Text = "Nazwisko";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(737, 38);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(514, 35);
            this.textBoxImie.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 71;
            this.label1.Text = "Imię";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.dateTimePickerDataUrodzenia);
            this.tabPage1.Controls.Add(this.buttonUsunZdjecie);
            this.tabPage1.Controls.Add(this.buttonDodajZdjecie);
            this.tabPage1.Controls.Add(this.listBoxZdjecia);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textBoxUwagi);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxMiejscowosc);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxPesel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxUlica);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxNazwisko);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxImie);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 63);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1371, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dane personalne";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 15);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1379, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewRejestracje);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 63);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1371, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wizyty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRejestracje
            // 
            this.dataGridViewRejestracje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRejestracje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewRejestracje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRejestracje.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewRejestracje.Name = "dataGridViewRejestracje";
            this.dataGridViewRejestracje.RowHeadersWidth = 72;
            this.dataGridViewRejestracje.RowTemplate.Height = 37;
            this.dataGridViewRejestracje.Size = new System.Drawing.Size(1365, 470);
            this.dataGridViewRejestracje.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RejestracjaId";
            this.Column1.HeaderText = "RejestracjaId";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "Lp";
            this.Column2.HeaderText = "Lp";
            this.Column2.MinimumWidth = 9;
            this.Column2.Name = "Column2";
            this.Column2.Width = 76;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxWizyty,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1365, 52);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxWizyty
            // 
            this.toolStripComboBoxWizyty.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxWizyty.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxWizyty.Items.AddRange(new object[] {
            "Tygodniu",
            "Miesiącu"});
            this.toolStripComboBoxWizyty.Margin = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.toolStripComboBoxWizyty.Name = "toolStripComboBoxWizyty";
            this.toolStripComboBoxWizyty.Size = new System.Drawing.Size(300, 38);
            this.toolStripComboBoxWizyty.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxWizyty_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(284, 46);
            this.toolStripLabel1.Text = "Pokaż wizyty dostępne w tym";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(1419, 635);
            this.panel4.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 100);
            this.panel1.TabIndex = 60;
            // 
            // EditPacjent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 835);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditPacjent";
            this.Text = "Edytowanie danych istniejącego lekarza";
            this.Load += new System.EventHandler(this.EditPacjent_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRejestracje)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataUrodzenia;
        private System.Windows.Forms.Button buttonUsunZdjecie;
        private System.Windows.Forms.Button buttonDodajZdjecie;
        private System.Windows.Forms.ListBox listBoxZdjecia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUwagi;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewRejestracje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxWizyty;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}