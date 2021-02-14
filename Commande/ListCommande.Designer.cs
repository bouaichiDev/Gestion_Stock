namespace Gestion_Stock.Commande
{
    partial class ListCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
             g_listCommande = new System.Windows.Forms.DataGridView();
            this.Supprimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)( g_listCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // g_listCommande
            // 
             g_listCommande.AllowUserToAddRows = false;
             g_listCommande.AllowUserToDeleteRows = false;
             g_listCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
             g_listCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             Supprimer});
             g_listCommande.Location = new System.Drawing.Point(0, 0);
             g_listCommande.Name = "g_listCommande";
             g_listCommande.ReadOnly = true;
             g_listCommande.Size = new System.Drawing.Size(1332, 802);
             g_listCommande.TabIndex = 0;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            // 
            // ListCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 802);
            this.Controls.Add( g_listCommande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListCommande";
            this.Text = "ListCommande";
            this.Load += new System.EventHandler(this.ListCommande_Load);
            ((System.ComponentModel.ISupportInitialize)( g_listCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Supprimer;
        public static System.Windows.Forms.DataGridView g_listCommande;
    }
}