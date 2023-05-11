using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLInjection
{
    public partial class FormPrijava : Form
    {

        public FormPrijava()
        {
            InitializeComponent();
            pozicioniraj();
   
        }

        private void pozicioniraj()
        {
            int xP = (Screen.PrimaryScreen.WorkingArea.Width - btnPrijaviSe.Width) / 2;
            int yP = (ClientSize.Height - btnPrijaviSe.Height) / 2 + 300;
            btnPrijaviSe.Location = new Point(xP, yP);

            int xG = (Screen.PrimaryScreen.WorkingArea.Width - gbPrijava.Width) / 2;
            int yG = (ClientSize.Height - gbPrijava.Height) / 2 + 100;
            gbPrijava.Location = new Point(xG, yG);
        }

        private void btnPrijaviSe_MouseEnter(object sender, EventArgs e)
        {
            btnPrijaviSe.BackColor = Color.Yellow;
        }

        private void btnPrijaviSe_MouseLeave(object sender, EventArgs e)
        {
            btnPrijaviSe.BackColor = SystemColors.MenuHighlight;
        }
    }
}
