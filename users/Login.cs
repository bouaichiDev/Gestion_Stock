using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Stock.Models;
using Gestion_Stock.user;
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
            try
            {

           
            
            string user = username.Text;
            string pass = password.Text;
            string param = "user_@string@"+user+ "#passe@string@" + pass;
                DataTable dt = Program.query.executeProc("Getuser", param);//kUPOUgsKHNWbvWfw

                //    string connString = "";

                //MySqlDataReader DbDataReader ;

                //var connectionString = "server=localhost; user id=root; password=; database=gs_stock; pooling=false;";//"Data Source=localhost; User Id=root; Password=; Initial Catalog=gestion_stock;persist security info=True; CharSet=utf8; Port=3306; pooling=false;"; // Provide connecction string here.
                //using (var connection = new MySqlConnection(connectionString))
                //{
                //      dt = new DataTable();
                //    MySqlCommand command = new MySqlCommand();
                //    command.CommandText = "SELECT * FROM users WHERE Login='" + user + "' AND Pass='" + pass + "'";

                //    command.Connection = connection;
                //    command.CommandType = CommandType.Text;






                //    command.Connection.Open();
                //     DbDataReader = command.ExecuteReader();
                //   // _dataReader = cmd.ExecuteReader(); //(_command);
                //    dt.Load(DbDataReader);
                //    command.Connection.Close();
                //}

                if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {

                        LoginInfo.UserID = dt.Rows[0]["ID"].ToString();
                        LoginInfo.AdminID = dt.Rows[0]["ID_admin"].ToString();
                        LoginInfo.LastName = dt.Rows[0]["LastName"].ToString();
                        LoginInfo.Name = dt.Rows[0]["Name"].ToString();
                        LoginInfo.mail = dt.Rows[0]["mail"].ToString();
                        LoginInfo.Login = dt.Rows[0]["Login"].ToString();
                        LoginInfo.pass = dt.Rows[0]["pass"].ToString();
                        LoginInfo.Phone = dt.Rows[0]["phone"].ToString();
                        LoginInfo.role = dt.Rows[0]["role"].ToString();
                        LoginInfo.app = dt.Rows[0]["appName"].ToString();
                        LoginInfo.dateExperation = DateTime.Parse( dt.Rows[0]["date"].ToString());

                        Accueil accueil = new Accueil();
                        //Login.ActiveForm.Hide();
                        accueil.Show();
                        this.Hide();

                }
                else
                    MessageBox.Show("NOP");
            }
            else
                MessageBox.Show("NOP");
            }
            catch (Exception EX) {


                MessageBox.Show(EX.Message);
            
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(Program.checkDB_Conn())
            init();
            
         
            
        }
    }
}
