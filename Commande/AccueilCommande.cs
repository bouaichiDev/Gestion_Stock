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
    public partial class AccueilCommande : Form
    {
        public AccueilCommande()
        {
            InitializeComponent();
        }

        private void Btn_ListeCommande(object sender, EventArgs e)
        {
            p_commande.Controls.Clear();
            ListCommande listCommande = new ListCommande() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            p_commande.Controls.Add(listCommande);
            listCommande.Show();
        }
    }
}
