namespace SQLInjection
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
            this.gbPrijava.SuspendLayout();
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
            this.btnPrijaviSe.Size = new System.Drawing.Size(322, 107);
            this.btnPrijaviSe.TabIndex = 4;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
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
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(995, 621);
            this.Controls.Add(this.gbPrijava);
            this.Controls.Add(this.btnPrijaviSe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbPrijava.ResumeLayout(false);
            this.gbPrijava.PerformLayout();
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
    }
}