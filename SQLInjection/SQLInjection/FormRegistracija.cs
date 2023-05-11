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
        MySqlConnection sqlConn = new MySqlConnection("server=localhost;user=root;password=baze2021;database=si");
        private string uuid;
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string lozinka;
        private string hashiranaLozinka;
        private string sol;
        private int brojRedova;

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

        private string kreirajSol()
        {
            var rng = new RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[16];
            rng.GetBytes(saltBytes);

            return Convert.ToBase64String(saltBytes);
        }

        private bool selectDB(string korisnickoIme)
        {
            string sqlUpit = "SELECT * FROM korisnik WHERE korisnicko_ime = '" + korisnickoIme + "'";
            MySqlCommand mySqlCmd = new MySqlCommand(sqlUpit, sqlConn);
            MySqlDataReader mySqlDataReader = mySqlCmd.ExecuteReader();
            bool pronadeno = mySqlDataReader.HasRows;
            mySqlDataReader.Close();
            return pronadeno;
        }

        private int insertInDB(string uuid, string ime, string prezime, string korisnickoIme, string hashiranaLozinka, string sol)
        {
            sqlConn.Open();
            brojRedova = 0;
            if (!selectDB(korisnickoIme))
            {
                string sqlUpit = "INSERT INTO korisnik (uuid, ime, prezime, korisnicko_ime, hashirana_lozinka, salt) " +
                "VALUES (@uuid, @ime, @prezime, @korisnickoIme, @hashiranaLozinka, @sol)";

                using (MySqlCommand command = new MySqlCommand(sqlUpit, sqlConn))
                {
                    command.Parameters.AddWithValue("@uuid", uuid);
                    command.Parameters.AddWithValue("@ime", ime);
                    command.Parameters.AddWithValue("@prezime", prezime);
                    command.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
                    command.Parameters.AddWithValue("@hashiranaLozinka", hashiranaLozinka);
                    command.Parameters.AddWithValue("@sol", sol);

                    brojRedova = command.ExecuteNonQuery();
                }
                sqlConn.Close();
                return brojRedova;
            }
            else
            {
                sqlConn.Close();
                return brojRedova;
            }
        }

        private int provjeriPolja()
        {
            if (string.IsNullOrEmpty(tbIme.Text) || string.IsNullOrEmpty(tbPrezime.Text) || string.IsNullOrEmpty(tbKorisnickoIme.Text) || string.IsNullOrEmpty(tbLozinka.Text))
            {
                MessageBox.Show("Potrebno je popuniti sva polja!");
                return 0;
            }
            return 1;
        }

        private string kreirajUUID()
        {
            return Guid.NewGuid().ToString();
        }

        private void ocistiPolja()
        {
            tbIme.Clear();
            tbPrezime.Clear();
            tbKorisnickoIme.Clear();
            tbLozinka.Clear();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            if (provjeriPolja() == 1)
            {
                uuid = kreirajUUID();
                ime = tbIme.Text;
                prezime = tbPrezime.Text;
                korisnickoIme = tbKorisnickoIme.Text;
                lozinka = tbLozinka.Text;
                sol = kreirajSol();
                hashiranaLozinka = hashirajLozinku(lozinka + sol);

                if (insertInDB(uuid, ime, prezime, korisnickoIme, hashiranaLozinka, sol) == 1)
                {
                    MessageBox.Show("Uspješna registracija!");
                    ocistiPolja();
                }
                else
                {
                    MessageBox.Show("Neuspješna registracija!");
                }
            }
        }
    }
}
