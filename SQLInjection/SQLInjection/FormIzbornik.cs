using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLInjection
{
    public partial class FormIzbornik : Form
    {
        MySqlConnection sqlConn = new MySqlConnection("server=localhost;user=root;password=baze2021;database=si");
        public FormIzbornik()
        {
            InitializeComponent();
            pozicioniraj();
        }

        private void pozicioniraj()
        {
            int xP = (Screen.PrimaryScreen.WorkingArea.Width - btnPrijava.Width) / 2;
            int yP = (ClientSize.Height - btnPrijava.Height) / 2 - 50;
            btnPrijava.Location = new Point(xP, yP);

            int xR = (Screen.PrimaryScreen.WorkingArea.Width - btnRegistracija.Width) / 2;
            int yR = (ClientSize.Height - btnRegistracija.Height) / 2 + 50;
            btnRegistracija.Location = new Point(xR, yR);
        }



        private void btnPrijava_Click(object sender, EventArgs e)
        {
            FormPrijava formPrijava = new FormPrijava();
            this.Hide();
            formPrijava.ShowDialog();
            this.Show();
        }


        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FormRegistracija formRegistracija = new FormRegistracija();
            this.Hide();
            formRegistracija.ShowDialog();
            this.Show();
        }

        private void btnPrijava_MouseEnter(object sender, EventArgs e)
        {
            btnPrijava.BackColor = Color.Yellow;
        }

        private void btnPrijava_MouseLeave(object sender, EventArgs e)
        {
            btnPrijava.BackColor = SystemColors.MenuHighlight;
        }

        private void btnRegistracija_MouseEnter(object sender, EventArgs e)
        {
            btnRegistracija.BackColor = Color.Yellow;
        }

        private void btnRegistracija_MouseLeave(object sender, EventArgs e)
        {
            btnRegistracija.BackColor = SystemColors.MenuHighlight;
        }
    }
}
