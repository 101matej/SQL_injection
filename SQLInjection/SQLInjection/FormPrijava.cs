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
        MySqlConnection sqlConn = new MySqlConnection("server=localhost;user=root;password=baze2021;database=si");
        public FormPrijava()
        {
            InitializeComponent();
            pozicioniraj();

            dgvKorisnici.AutoGenerateColumns = true;
            dgvKorisnici.ReadOnly = true;
            dgvKorisnici.AutoSize = true;
            prikaziKorisnike();
        }

        private void pozicioniraj()
        {
            int xP = (Screen.PrimaryScreen.WorkingArea.Width - btnPrijaviSe.Width) / 2;
            int yP = (ClientSize.Height - btnPrijaviSe.Height) / 2 + 300;
            btnPrijaviSe.Location = new Point(xP, yP);

            int xG = (Screen.PrimaryScreen.WorkingArea.Width - gbPrijava.Width) / 2;
            int yG = (ClientSize.Height - gbPrijava.Height) / 2 + 100;
            gbPrijava.Location = new Point(xG, yG);

            int xD = (Screen.PrimaryScreen.WorkingArea.Width - dgvKorisnici.Width) / 4 - 110;
            int yD = (ClientSize.Height - dgvKorisnici.Height) / 2 - 110;
            dgvKorisnici.Location = new Point(xD, yD);
        }

        private void prikaziKorisnike()
        {
            try
            {
                sqlConn.Open();

                string query = "SELECT * FROM korisnik";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvKorisnici.DataSource = dataTable;
                dgvKorisnici.Columns["uuid"].HeaderText = "UUID";
                dgvKorisnici.Columns["ime"].HeaderText = "IME";
                dgvKorisnici.Columns["prezime"].HeaderText = "PREZIME";
                dgvKorisnici.Columns["korisnicko_ime"].HeaderText = "KORISNIČKO IME";
                dgvKorisnici.Columns["hashirana_lozinka"].HeaderText = "HASH LOZINKA";
                dgvKorisnici.Columns["salt"].HeaderText = "SOL";
                dgvKorisnici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Prikaz korisnika nije uspio: " + ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
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
