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
    }
}
