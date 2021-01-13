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
using Gestion_Stock.Models;
namespace Gestion_Stock.Clients
{
    public partial class ListClient : Form
    {
        public ListClient()
        {
            InitializeComponent();
        }
        public static void reloadGridClient()
        {
            string user = LoginInfo.AdminID;

            string param = "admin_@int@" + user;
            DataTable dt = Program.query.executeProc("GetListClient", param);
            g_listClient.DataSource = null;

            g_listClient.DataSource = dt;

            g_listClient.Columns[0].ReadOnly = false;
        }
        private void ListClient_Load(object sender, EventArgs e)
        {

            reloadGridClient();
        }
        public static string listSuprimerClient = "";
        private void g_listClient_SelectionChanged(object sender, EventArgs e)
        {
           

        }

        private void g_listClient_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                  
                    if (g_listClient.SelectedRows.Count >= 0)
                    {
                        int row = e.RowIndex;
                        string name = g_listClient.Rows[row].Cells[1].Value.ToString();
                        MessageBox.Show(name);
                    }
            }
            catch { }
            
        }

        private void g_listClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void g_listClient_Click(object sender, EventArgs e)
        {
          
        }

        private void g_listClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            foreach (DataGridViewRow row in g_listClient.Rows)
            {

                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {

                    listSuprimerClient += row.Cells[2].Value.ToString();
                }
            }
            
        }
    }
}
