namespace SQLInjection
{
    partial class FormIzbornik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzbornik));
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.Location = new System.Drawing.Point(255, 69);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(322, 107);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            this.btnPrijava.MouseEnter += new System.EventHandler(this.btnPrijava_MouseEnter);
            this.btnPrijava.MouseLeave += new System.EventHandler(this.btnPrijava_MouseLeave);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistracija.Location = new System.Drawing.Point(255, 208);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(322, 107);
            this.btnRegistracija.TabIndex = 1;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            this.btnRegistracija.MouseEnter += new System.EventHandler(this.btnRegistracija_MouseEnter);
            this.btnRegistracija.MouseLeave += new System.EventHandler(this.btnRegistracija_MouseLeave);
            // 
            // FormIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Injection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistracija;
    }
}

