﻿
namespace WinFormsApp96.Forms.Specjalizacje
{
    partial class SpecjalizacjeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecjalizacjeUserControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSpecjalizacje = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDodaj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsun = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModyfikuj = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxWyszukiwarka = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecjalizacje)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 535);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSpecjalizacje);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista specjalizacji";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSpecjalizacje
            // 
            this.dataGridViewSpecjalizacje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecjalizacje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewSpecjalizacje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSpecjalizacje.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewSpecjalizacje.Name = "dataGridViewSpecjalizacje";
            this.dataGridViewSpecjalizacje.RowHeadersWidth = 72;
            this.dataGridViewSpecjalizacje.RowTemplate.Height = 37;
            this.dataGridViewSpecjalizacje.Size = new System.Drawing.Size(938, 430);
            this.dataGridViewSpecjalizacje.TabIndex = 9;
            this.dataGridViewSpecjalizacje.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSpecjalizacje_CellMouseClick);
            this.dataGridViewSpecjalizacje.SelectionChanged += new System.EventHandler(this.dataGridViewSpecjalizacje_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodaj,
            this.toolStripButtonUsun,
            this.toolStripButtonModyfikuj,
            this.toolStripTextBoxWyszukiwarka,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(938, 52);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDodaj
            // 
            this.toolStripButtonDodaj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodaj.Image")));
            this.toolStripButtonDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodaj.Name = "toolStripButtonDodaj";
            this.toolStripButtonDodaj.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.toolStripButtonDodaj.Size = new System.Drawing.Size(100, 46);
            this.toolStripButtonDodaj.Text = "Dodaj";
            this.toolStripButtonDodaj.Click += new System.EventHandler(this.toolStripButtonDodaj_Click);
            // 
            // toolStripButtonUsun
            // 
            this.toolStripButtonUsun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUsun.Image")));
            this.toolStripButtonUsun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsun.Name = "toolStripButtonUsun";
            this.toolStripButtonUsun.Size = new System.Drawing.Size(92, 46);
            this.toolStripButtonUsun.Text = "Usuń";
            this.toolStripButtonUsun.Click += new System.EventHandler(this.toolStripButtonUsun_Click);
            // 
            // toolStripButtonModyfikuj
            // 
            this.toolStripButtonModyfikuj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModyfikuj.Image")));
            this.toolStripButtonModyfikuj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModyfikuj.Name = "toolStripButtonModyfikuj";
            this.toolStripButtonModyfikuj.Size = new System.Drawing.Size(137, 46);
            this.toolStripButtonModyfikuj.Text = "Modyfikuj";
            this.toolStripButtonModyfikuj.Click += new System.EventHandler(this.toolStripButtonModyfikuj_Click);
            // 
            // toolStripTextBoxWyszukiwarka
            // 
            this.toolStripTextBoxWyszukiwarka.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBoxWyszukiwarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxWyszukiwarka.Name = "toolStripTextBoxWyszukiwarka";
            this.toolStripTextBoxWyszukiwarka.Size = new System.Drawing.Size(300, 52);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 46);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SpecjalizacjaId";
            this.Column1.HeaderText = "SpecjalizacjaId";
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
            // SpecjalizacjeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "SpecjalizacjeUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(992, 575);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecjalizacje)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewSpecjalizacje;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodaj;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsun;
        private System.Windows.Forms.ToolStripButton toolStripButtonModyfikuj;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxWyszukiwarka;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
