﻿namespace SQLInjection
{
    partial class FormPrijava
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrijava));
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.gbPrijava = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.tbPrijavljeniKorisnik = new System.Windows.Forms.TextBox();
            this.lbPrijavljeniKorisnik = new System.Windows.Forms.Label();
            this.cbSql = new System.Windows.Forms.CheckBox();
            this.rtbHint = new System.Windows.Forms.RichTextBox();
            this.gbPrijava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKorisnickoIme.Location = new System.Drawing.Point(123, 50);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(193, 29);
            this.lbKorisnickoIme.TabIndex = 0;
            this.lbKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lbLozinka
            // 
            this.lbLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLozinka.Location = new System.Drawing.Point(123, 107);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(109, 29);
            this.lbLozinka.TabIndex = 1;
            this.lbLozinka.Text = "Lozinka:";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKorisnickoIme.Location = new System.Drawing.Point(350, 35);
            this.tbKorisnickoIme.Multiline = true;
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(324, 44);
            this.tbKorisnickoIme.TabIndex = 2;
            this.tbKorisnickoIme.MouseEnter += new System.EventHandler(this.tbKorisnickoIme_MouseEnter);
            this.tbKorisnickoIme.MouseLeave += new System.EventHandler(this.tbKorisnickoIme_MouseLeave);
            // 
            // tbLozinka
            // 
            this.tbLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLozinka.Location = new System.Drawing.Point(350, 92);
            this.tbLozinka.Multiline = true;
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(324, 44);
            this.tbLozinka.TabIndex = 3;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijaviSe.Location = new System.Drawing.Point(249, 365);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(362, 107);
            this.btnPrijaviSe.TabIndex = 4;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            this.btnPrijaviSe.MouseEnter += new System.EventHandler(this.btnPrijaviSe_MouseEnter);
            this.btnPrijaviSe.MouseLeave += new System.EventHandler(this.btnPrijaviSe_MouseLeave);
            // 
            // gbPrijava
            // 
            this.gbPrijava.AutoSize = true;
            this.gbPrijava.BackColor = System.Drawing.Color.LightCoral;
            this.gbPrijava.Controls.Add(this.tbKorisnickoIme);
            this.gbPrijava.Controls.Add(this.lbKorisnickoIme);
            this.gbPrijava.Controls.Add(this.tbLozinka);
            this.gbPrijava.Controls.Add(this.lbLozinka);
            this.gbPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrijava.Location = new System.Drawing.Point(93, 26);
            this.gbPrijava.Name = "gbPrijava";
            this.gbPrijava.Size = new System.Drawing.Size(800, 175);
            this.gbPrijava.TabIndex = 5;
            this.gbPrijava.TabStop = false;
            this.gbPrijava.Text = "Prijava:";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(653, 272);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.Size = new System.Drawing.Size(240, 150);
            this.dgvKorisnici.TabIndex = 6;
            // 
            // tbPrijavljeniKorisnik
            // 
            this.tbPrijavljeniKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrijavljeniKorisnik.Location = new System.Drawing.Point(350, 797);
            this.tbPrijavljeniKorisnik.Multiline = true;
            this.tbPrijavljeniKorisnik.Name = "tbPrijavljeniKorisnik";
            this.tbPrijavljeniKorisnik.Size = new System.Drawing.Size(324, 44);
            this.tbPrijavljeniKorisnik.TabIndex = 7;
            // 
            // lbPrijavljeniKorisnik
            // 
            this.lbPrijavljeniKorisnik.AutoSize = true;
            this.lbPrijavljeniKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPrijavljeniKorisnik.Location = new System.Drawing.Point(62, 812);
            this.lbPrijavljeniKorisnik.Name = "lbPrijavljeniKorisnik";
            this.lbPrijavljeniKorisnik.Size = new System.Drawing.Size(213, 29);
            this.lbPrijavljeniKorisnik.TabIndex = 8;
            this.lbPrijavljeniKorisnik.Text = "Prijavljeni korisnik:";
            // 
            // cbSql
            // 
            this.cbSql.AutoSize = true;
            this.cbSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSql.Location = new System.Drawing.Point(736, 506);
            this.cbSql.Name = "cbSql";
            this.cbSql.Size = new System.Drawing.Size(391, 33);
            this.cbSql.TabIndex = 10;
            this.cbSql.Text = "SQL Injection prevencija (DA/NE)";
            this.cbSql.UseVisualStyleBackColor = true;
            // 
            // rtbHint
            // 
            this.rtbHint.Location = new System.Drawing.Point(847, 404);
            this.rtbHint.Name = "rtbHint";
            this.rtbHint.Size = new System.Drawing.Size(376, 59);
            this.rtbHint.TabIndex = 11;
            this.rtbHint.Text = "Testiranje SQL injection napada:\nKorisničko ime: \' OR \'1\'=\'1\' --\'\nLozinka: bilo k" +
    "oja iz baze podataka registriranih korisnika";
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(995, 873);
            this.Controls.Add(this.rtbHint);
            this.Controls.Add(this.cbSql);
            this.Controls.Add(this.lbPrijavljeniKorisnik);
            this.Controls.Add(this.tbPrijavljeniKorisnik);
            this.Controls.Add(this.dgvKorisnici);
            this.Controls.Add(this.gbPrijava);
            this.Controls.Add(this.btnPrijaviSe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbPrijava.ResumeLayout(false);
            this.gbPrijava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.GroupBox gbPrijava;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.TextBox tbPrijavljeniKorisnik;
        private System.Windows.Forms.Label lbPrijavljeniKorisnik;
        private System.Windows.Forms.CheckBox cbSql;
        private System.Windows.Forms.RichTextBox rtbHint;
    }
}