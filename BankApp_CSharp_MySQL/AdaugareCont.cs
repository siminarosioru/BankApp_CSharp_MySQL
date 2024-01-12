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
    public partial class AdaugareCont : Form
    {
        //conexiunea cu sql
        string conString = "server=localhost;uid=root;pwd=**********;database=bankapp_mysql_db";

        //constructor fara parametrii
        public AdaugareCont()
        {
            InitializeComponent();
        }

        //constructor cu parametrii
        public AdaugareCont(string nume, string prenume, string cnp, string adresa, string telefon)
        {
            InitializeComponent();
            textBox_cnp.Text = cnp;
            textBox_nume.Text = nume;
            textBox_prenume.Text = prenume;
            textBox_adresa.Text = adresa;
            textBox_telefon.Text = telefon;
        }

         private void btn_Adaugare_cont_Click(object sender, EventArgs e)
        {
            //crearea conexiunii
            MySqlConnection con = new MySqlConnection();

            try
            {
                con.connectionString = conString;
                con.Open();

                //creez query-ul numit sqlInsert
                string sqlInsert = "INSERT INTO iban(CNP, Tip_cont, Numar, Sold) VALUES('" + textBox_cnp.Text + "', '" +
                    comboBox_tipCont.Text + "', '" + textBox_numar.Text + "', '" + textBox_sold.Text + "')";

                MySqlCommand cmd = new MySqlCommand(sqlInsert, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //the information for the "AdaugareCont" interface
        private void AdaugareCont_Load(object sender, EventArgs e)
        {
            //crearea conexiunii
            MySqlConnection con = new MySqlConnection();
            con.connectionString = conString;
            con.Open();

            //creez query-ul numit selectQuery
            string selectQuery = "SELECT * FROM iban WHERE CNP='" + textBox_cnp.Text + "'";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void btn_Actualizare_date_Click(object sender, EventArgs e)
        {
            try
            {
                //crearea conexiunii
                MySqlConnection con = new MySqlConnection();
                con.connectionString = conString;
                con.Open();

                //creez query-ul numit selectQuery
                string selectQuery="SELECT * FROM iban WHERE CNP='" + textBox_cnp.Text + "'";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, con);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
