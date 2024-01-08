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

        }

        
    }
}
