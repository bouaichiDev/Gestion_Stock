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
using Gestion_Stock.Class;
namespace Gestion_Stock.user
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Clients.AccueilClient objForm2 = new Clients.AccueilClient() { Dock=DockStyle.Fill,TopLevel=false,TopMost=false};
            panel1.Controls.Add(objForm2);
            objForm2.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            if (!Verification.checkUser())
            {
                this.Close();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
