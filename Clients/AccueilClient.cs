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

namespace Gestion_Stock.Clients
{
    public partial class AccueilClient : Form
    {
        public AccueilClient()
        {
            InitializeComponent();
        }

        private void Btn_ListeClients_Click(object sender, EventArgs e)
        {
            p_client.Controls.Clear();
            ListClient listClient = new ListClient() { Dock=DockStyle.Fill,TopLevel=false,TopMost=false};
            p_client.Controls.Add(listClient);
            listClient.Show();

        }
       // public static DataRow row=null;
        public static DataGridView row1 = null;
        
        private void Btn_ModifierClient_Click(object sender, EventArgs e)
        {
            row1 = new DataGridView();  
            if (ListClient.g_listClient.SelectedRows.Count != 1)
            {
                MessageBox.Show("select client");
            }
            else
            {
                // Set up a List<T> to hold the indexes of the visible columns
                List<int> visibleColumns = new List<int>();
                //int j = 0; j < dataGridView1.Columns.Count; j++DataGridViewColumn col in ListClient.g_listClient.Columns
                for (int j = 0; j < ListClient.g_listClient.Columns.Count; j++)
                {
                    if (ListClient.g_listClient.Columns[j].Visible)
                    {
                        row1.Columns.Add((DataGridViewColumn)ListClient.g_listClient.Columns[j].Clone()); 

                        visibleColumns.Add(ListClient.g_listClient.Columns[j].Index);
                    }
                }

                // Now add the data from the columns
                // Set a counter for the current row index for the second DataGridView
                int rowIndex = 0;
                row1.Rows.Clear();
                row1.Refresh();
                 
                foreach (DataGridViewRow row in ListClient.g_listClient.SelectedRows)
                {

                    // Add a new row to the DataGridView
                    //row1.Rows.Add();

                    // Loop through the visible columns
                    for (int i = 0; i < visibleColumns.Count; i++)
                    {
                        // Use the index of the for loop for the column in the target data grid
                        // Use the index value from the List<T> for the cell of the source target data grid
                        row1.Rows[rowIndex].Cells[i].Value = row.Cells[visibleColumns[i]].Value;
                    }

                    // Increment the rowIndex
                    rowIndex++;
                    
                }

                p_client.Controls.Clear();
                GS_Client UPDATEClient = new GS_Client() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
                p_client.Controls.Add(UPDATEClient);
                UPDATEClient.Show();
            }

        }

        private void Btn_AjouterClient_Click(object sender, EventArgs e)
        {
            p_client.Controls.Clear();
            GS_Client ADDClient = new GS_Client() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            p_client.Controls.Add(ADDClient);
            ADDClient.Show();
        }

        private void Btn_SupprimerClient_Click(object sender, EventArgs e)
        {
            
             
            foreach (DataGridViewRow s in ListClient.g_listClient.SelectedRows)
            {
                //MessageBox.Show(s.Cells[2].Value.ToString());
                gestion gestion = new gestion();
                List<data_> data = new List<data_>();
                data_ data_1 = new data_();
                data_1.name = "Active"; 
                data_1.type ="int";
                data_1.valeur = "-1";
                data.Add(data_1);
                gestion.Update("Clients",data,"","ID="+s.Cells[1].Value.ToString());

            }
            ListClient.reloadGridClient();
        }

        private void Btn_DesactiverClient_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow s in ListClient.g_listClient.SelectedRows)
            {
                //MessageBox.Show(s.Cells[2].Value.ToString());
                gestion gestion = new gestion();
                List<data_> data = new List<data_>();
                data_ data_1 = new data_();
                data_1.name = "Active";
                data_1.type = "int";
                data_1.valeur = "0";
                data.Add(data_1);
                gestion.Update("Clients", data, "", "ID=" + s.Cells[1].Value.ToString());

            }
            ListClient.reloadGridClient();
        }
    }
}
