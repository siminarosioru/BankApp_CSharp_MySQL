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
    public partial class AdaugareUtilizator : Form
    {
        //conexiunea cu sql
        string conString = "server=localhost;uid=root;pwd=**********;database=bankapp_mysql_db";

        //constructor
        public AdaugareUtilizator()
        {
            InitializeComponent();
        }

        private void btn_adaugare_utilizator_Click(object sender, EventArgs e)
        {
            try
            {
                //crearea conexiunii
                MySqlConnection con = new MySqlConnection();
                con.connectionString = conString;
                con.Open(); //conexiunea este deschisa

                string rol = "banca";
                //creez query-ul numit sqlInsert
                string sqlInsert = "INSERT INTO login(Utilizator, Parola, Nume, Prenume, Rol) VALUES('" + textBox_utilizator.Text + "', '" + textBox_parola.Text + "', '" 
                    + textBox_nume.Text + "', '" + textBox_prenume.Text + "', '" + rol + "')";

                MySqlCommand cmd = new MySqlCommand(sqlInsert);
                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actualizare_date_Click(object sender, EventArgs e)
        {

        }
    }
}
