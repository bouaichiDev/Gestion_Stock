using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Stock.Models;
using MySql;
using MySql.Data.MySqlClient;

namespace Gestion_Stock
{
    public partial class Login : Form
    {
 
        public Login()
        {
            InitializeComponent();
        }
        public void init()
        {
            Configs configs = new Configs();

        }
        private void cnx_Click(object sender, EventArgs e)
        {
            
            string user = username.Text;
            string pass = password.Text;
            string param = "user_@string@"+user+"#passe@string@"+pass;
            DataTable dt= Program.query.executeProc("Getuser", param);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    LoginInfo.UserID = dt.Rows[0][0].ToString();
                }
                else
                    MessageBox.Show("NOP");
            }
            else
                MessageBox.Show("NOP");

           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
