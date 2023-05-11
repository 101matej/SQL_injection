namespace SQLInjection
{
    partial class FormRegistracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistracija));
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.btnRegistrirajSe = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbRegistracija = new System.Windows.Forms.GroupBox();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.gbRegistracija.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLozinka
            // 
            this.tbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLozinka.Location = new System.Drawing.Point(354, 211);
            this.tbLozinka.Multiline = true;
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(324, 44);
            this.tbLozinka.TabIndex = 7;
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKorisnickoIme.Location = new System.Drawing.Point(354, 154);
            this.tbKorisnickoIme.Multiline = true;
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(324, 44);
            this.tbKorisnickoIme.TabIndex = 6;
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLozinka.Location = new System.Drawing.Point(127, 226);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(109, 29);
            this.lbLozinka.TabIndex = 5;
            this.lbLozinka.Text = "Lozinka:";
            // 
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKorisnickoIme.Location = new System.Drawing.Point(127, 169);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(193, 29);
            this.lbKorisnickoIme.TabIndex = 4;
            this.lbKorisnickoIme.Text = "Korisničko ime:";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrezime.Location = new System.Drawing.Point(354, 95);
            this.tbPrezime.Multiline = true;
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(324, 44);
            this.tbPrezime.TabIndex = 11;
            // 
            // btnRegistrirajSe
            // 
            this.btnRegistrirajSe.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistrirajSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistrirajSe.Location = new System.Drawing.Point(315, 335);
            this.btnRegistrirajSe.Name = "btnRegistrirajSe";
            this.btnRegistrirajSe.Size = new System.Drawing.Size(348, 114);
            this.btnRegistrirajSe.TabIndex = 12;
            this.btnRegistrirajSe.Text = "Registriraj se";
            this.btnRegistrirajSe.UseVisualStyleBackColor = false;
            this.btnRegistrirajSe.Click += new System.EventHandler(this.btnRegistrirajSe_Click);
            this.btnRegistrirajSe.MouseEnter += new System.EventHandler(this.btnRegistrirajSe_MouseEnter);
            this.btnRegistrirajSe.MouseLeave += new System.EventHandler(this.btnRegistrirajSe_MouseLeave);
            // 
            // gbRegistracija
            // 
            this.gbRegistracija.BackColor = System.Drawing.Color.LightCoral;
            this.gbRegistracija.Controls.Add(this.lbPrezime);
            this.gbRegistracija.Controls.Add(this.lbKorisnickoIme);
            this.gbRegistracija.Controls.Add(this.tbPrezime);
            this.gbRegistracija.Controls.Add(this.lbLozinka);
            this.gbRegistracija.Controls.Add(this.tbIme);
            this.gbRegistracija.Controls.Add(this.tbKorisnickoIme);
            this.gbRegistracija.Controls.Add(this.tbLozinka);
            this.gbRegistracija.Controls.Add(this.lbIme);
            this.gbRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbRegistracija.Location = new System.Drawing.Point(569, 34);
            this.gbRegistracija.Name = "gbRegistracija";
            this.gbRegistracija.Size = new System.Drawing.Size(800, 300);
            this.gbRegistracija.TabIndex = 13;
            this.gbRegistracija.TabStop = false;
            this.gbRegistracija.Text = "Registracija";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPrezime.Location = new System.Drawing.Point(127, 110);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(116, 29);
            this.lbPrezime.TabIndex = 9;
            this.lbPrezime.Text = "Prezime:";
            // 
            // tbIme
            // 
            this.tbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbIme.Location = new System.Drawing.Point(354, 38);
            this.tbIme.Multiline = true;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(324, 44);
            this.tbIme.TabIndex = 10;
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbIme.Location = new System.Drawing.Point(127, 53);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(63, 29);
            this.lbIme.TabIndex = 8;
            this.lbIme.Text = "Ime:";
            // 
            // FormRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1389, 450);
            this.Controls.Add(this.gbRegistracija);
            this.Controls.Add(this.btnRegistrirajSe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbRegistracija.ResumeLayout(false);
            this.gbRegistracija.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button btnRegistrirajSe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbRegistracija;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lbIme;
    }
}