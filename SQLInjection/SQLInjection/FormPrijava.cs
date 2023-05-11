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
        private string korisnickoIme;
        private string lozinka;
        private string hashiranaLozinka;
        private string sol;
        
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

        private void selectDB(string korisnickoIme)
        {
            sqlConn.Open();
            hashiranaLozinka = "";
            sol = "";
            string sqlUpit = "SELECT * FROM korisnik WHERE korisnicko_ime = '" + korisnickoIme + "'";
            MySqlCommand mySqlCmd = new MySqlCommand(sqlUpit, sqlConn);
            MySqlDataReader mySqlDataReader = mySqlCmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                hashiranaLozinka = mySqlDataReader["hashirana_lozinka"].ToString();
                sol = mySqlDataReader["salt"].ToString();
            }
            sqlConn.Close();
        }

        private string hashirajLozinku(string posoljenaLozinka)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(posoljenaLozinka));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void ocistiPolja()
        {
            tbKorisnickoIme.Clear();
            tbLozinka.Clear();
        }

        private int provjeriPolja()
        {
            if (string.IsNullOrEmpty(tbKorisnickoIme.Text) || string.IsNullOrEmpty(tbLozinka.Text))
            {
                MessageBox.Show("Potrebno je popuniti sva polja!");
                return 0;
            }
            return 1;
        }

        private void provjeraLozinke()
        {
            lozinka = tbLozinka.Text;
            lozinka = lozinka + sol;

            if (hashiranaLozinka == hashirajLozinku(lozinka))
            {
                MessageBox.Show("Uspješna prijava!");
                ocistiPolja();
            }
            else
            {
                MessageBox.Show("Pogrešna lozinka!");
            }
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (provjeriPolja() == 1)
            {
                korisnickoIme = tbKorisnickoIme.Text;
                selectDB(korisnickoIme);
                provjeraLozinke();
            }
        }
    }
}
