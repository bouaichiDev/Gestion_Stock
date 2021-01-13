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
    public partial class GS_Client : Form
    {
        public GS_Client()
        {
            InitializeComponent();
        }

        private void Client_Save_Click(object sender, EventArgs e)
        {
            gestion gs = new gestion();
            
            List < data_ > s= new List<data_>();

           // string t = Name_client.Tag.ToString();
           
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    //((TextBox)x).Text = String.Empty;
                    data_ data_1 = new data_();
                    data_1.name = x.Name.Replace("_client","");
                    //data_1.type = "string";
                    data_1.type = x.Tag.ToString();
                    data_1.valeur = x.Text;
                    s.Add(data_1);
                    if (x.Text == "")
                    { MessageBox.Show(x.Name + " Vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //var test = 1;
                        var labels = Controls.Find(x.Name + "_label_erreur", true);
                        if (labels.Length > 0)
                        {
                            var label = (Label)labels[0];
                            label.Name = x.Name + "_label_erreur";
                            label.Text = "Some text goes here...";
                        }

                        return; }
                }
            }
            data_ data_2 = new data_();
            data_2.name = "ADMIN_ID";// 


            data_2.type = "int";
            data_2.valeur = LoginInfo.AdminID;
            s.Add(data_2);
            if(IDClient==0)
            gs.ADD("clients", s, "0");
            else
            gs.Update("clients", s, "0", " ID="+IDClient.ToString());

            AccueilClient.Btn_ListeClients.PerformClick();
        }
        public int IDClient = 0;
        private void GS_Client_Load(object sender, EventArgs e)
        {
            if(AccueilClient.row1!=null)
            if(AccueilClient.row1.Rows.Count>0)
            foreach (DataGridViewRow row_ in AccueilClient.row1.Rows)
            {

                    IDClient = int.Parse(row_.Cells[1].Value.ToString());
                    Name_client.Text = row_.Cells[2].Value.ToString();
                    LastName_client.Text = row_.Cells[3].Value.ToString();
                    address_client.Text = row_.Cells[4].Value.ToString();
                    Phone_client.Text = row_.Cells[5].Value.ToString();
                    Mail_client.Text = row_.Cells[6].Value.ToString();
                    raisonSocial_client.Text = row_.Cells[7].Value.ToString();
                    Pays_client.Text = row_.Cells[8].Value.ToString();
                }
        }
    }
}
