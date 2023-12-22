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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //buton Autentificare
        private void button1_Click(object sender, EventArgs e)
        {
            //conexiunea cu mysql
            string conString = "server=localhost;uid=root;pwd=**********;database=bankapp_mysql_db";

            //crearea conexiunii
            try
            {
#pragma warning disable IDE0017 // Simplify object initialization
                MySqlConnection con = new MySqlConnection();
#pragma warning restore IDE0017 // Simplify object initialization
                con.connectionString = conString;
                con.Open();

                //creez query-ul numit sql
                string sql = "select * from login";
                MySqlCommand cmd = new MySqlCommand(sql);

                int gasit = 0;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (textBox_nume.Text == reader["Utilizator"].ToString() && textBox_parola.Text == reader["Parola"].ToString()
                        && reader["Rol"].ToString() == "administrator")
                    {
                        AdaugareUtilizator ob_adaugareUtilizator = new AdaugareUtilizator();
                        gasit = 1;
                        ob_adaugareUtilizator.Show();
                    }
                    else if(textBox_nume.Text == reader["Utilizator"].ToString() && textBox_parola.Text == reader["Parola"].ToString() 
                        && reader["Rol"].ToString() == "banca")
                    {
                        string idLogin = reader["IdLogin"].ToString();
                        Clienti ob_clienti = new Clienti(idLogin);
                        gasit = 1;
                        ob_clienti.Show();
                    }
                }

                if (gasit == 0)
                    MessageBox.Show("Utilizator/Parola gresita");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    internal class MySqlConnection
    {
        public string connectionString { get; internal set; }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
