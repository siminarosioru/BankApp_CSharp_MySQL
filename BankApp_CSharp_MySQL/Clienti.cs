using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp_CSharp_MySQL
{
    public partial class Clienti : Form
    {
        //conexiunea cu sql
        string conString= "server=localhost;uid=root;pwd=**********;database=bankapp_mysql_db";

        //constructor fara parametrii
        public Clienti()
        {
            InitializeComponent();
        }

        //constructor cu un parametru
        public Clienti(string idLogin)
        {
            InitializeComponent();
            label6.Text = idLogin; //label6 nu se vede la compilare
            label6.Visible = false;
        }

        private void btn_Adaugare_Click(object sender, EventArgs e)
        {
            //crearea conexiunii
            MySqlConnection con = new MySqlConnection();

            try
            {
                con.connectionString = conString;
                //conexiunea este dechisa
                con.Open();

                //creez query-ul numit sqlInsert
                string sqlInsert = "INSERT INTO client(CNP, Nume, Prenume, Adresa, IdLogin, Telefon) VALUES('" +
                    textBox_CNP.Text + "', '" + textBox_Nume.Text + "', '" + textBox_Prenume.Text + "', '" +
                    textBox_Adresa.Text + "', '" + label6.Text + "', '" + textBox_Telefon.Text + "')";

                MySqlCommand cmd = new MySqlCommand(sqlInsert, con);
                int i = cmd.ExecuteNonQuery();
                //conexiunea este inchisa
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Actulizare_date_Click(object sender, EventArgs e)
        {
            try
            {
                //crearea conexiunii
                MySqlConnection con = new MySqlConnection();
                con.connectionString = conString;
                con.Open();

                //creez query-ul numit selectQuery
                string selectQuery = "SELECT * FROM client";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
                adapter.Fill(table);
                dataGridView_BankApp.DataSource = table;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clienti_Load(object sender, EventArgs e)
        {
            //crearea conexiunii
            MySqlConnection con = new MySqlConnection();
            con.connectionString = conString;
            //conexiunea este deschisa
            con.Open();

            //creez query-ul numit selectQuery
            string selectQuery = "SELECT * FROM client";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            dataGridView_BankApp.DataSource = table;
            con.Close();
        }
        private void btn_Modificare_Click(object sender, EventArgs e)
        {
            //crearea conexiunii
            MySqlConnection con = new MySqlConnection();

            if (string.IsNullOrEmpty(textBox_Nume.Text) || string.IsNullOrEmpty(textBox_Prenume.Text) ||
                string.IsNullOrEmpty(textBox_CNP.Text) || string.IsNullOrEmpty(textBox_Adresa.Text) ||
                string.IsNullOrEmpty(textBox_Telefon.Text))
                MessageBox.Show("Selectati inregistrarea care doriti sa o modificati!");
            else
            {
                try
                {
                    con.connectionString = conString;
                    con.Open();

                    //creez query-ul numit sqlUpdate
                    string sqlUpdate = "UPDATE client SET Nume='" + textBox_Nume.Text + "', " + "Prenume='" + textBox_Prenume.Text + "',Adresa='" +
                        textBox_Adresa.Text + "',Telefon='" + textBox_Telefon.Text +
                        "'WHERE CNP='" + textBox_CNP.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(sqlUpdate, con);
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
    }
}
