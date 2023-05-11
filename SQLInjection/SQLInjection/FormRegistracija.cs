using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace SQLInjection
{
    public partial class FormRegistracija : Form
    {
        public FormRegistracija()
        {
            InitializeComponent();
            pozicioniraj();
        }

        private void pozicioniraj()
        {
            int xP = (Screen.PrimaryScreen.WorkingArea.Width - btnRegistrirajSe.Width) / 2;
            int yP = (ClientSize.Height - btnRegistrirajSe.Height) / 2 + 300;
            btnRegistrirajSe.Location = new Point(xP, yP);

            int xG = (Screen.PrimaryScreen.WorkingArea.Width - gbRegistracija.Width) / 2;
            int yG = (ClientSize.Height - gbRegistracija.Height) / 2 + 50;
            gbRegistracija.Location = new Point(xG, yG);
        }

        private void btnRegistrirajSe_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrirajSe.BackColor = Color.Yellow;
        }

        private void btnRegistrirajSe_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrirajSe.BackColor = SystemColors.MenuHighlight;
        }
    }
}
