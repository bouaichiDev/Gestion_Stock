using Gestion_Stock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock.Commande
{
    public partial class ListCommande : Form
    {
        public ListCommande()
        {
            InitializeComponent();
        }
        public static string listSuprimerCcommade = "";
        public static void reloadGridCommande()
        {
            string user = LoginInfo.AdminID;

            string param = "admin_@int@" + user;
            DataTable dt = Program.query.executeProc("GetListClient", param);
            g_listCommande.DataSource = null;

            g_listCommande.DataSource = dt;

            g_listCommande.Columns[0].ReadOnly = false;
        }

        private void ListCommande_Load(object sender, EventArgs e)
        {
            reloadGridCommande();
        }
        private void g_listCommande_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {

                if (g_listCommande.SelectedRows.Count >= 0)
                {
                    int row = e.RowIndex;
                    string name = g_listCommande.Rows[row].Cells[1].Value.ToString();
                    MessageBox.Show(name);
                }
            }
            catch { }

        }
        private void g_listCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            foreach (DataGridViewRow row in g_listCommande.Rows)
            {

                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {

                    listSuprimerCcommade += row.Cells[2].Value.ToString();
                }
            }

        }
    }
}
