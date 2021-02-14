namespace Gestion_Stock.Clients
{
    partial class AccueilClient
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
             Btn_ListeClients = new System.Windows.Forms.Button();
            this.Btn_AjouterClient = new System.Windows.Forms.Button();
            this.Btn_ModifierClient = new System.Windows.Forms.Button();
            this.Btn_SupprimerClient = new System.Windows.Forms.Button();
            this.Btn_DesactiverClient = new System.Windows.Forms.Button();
            this.p_client = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Btn_ListeClients
            // 
             Btn_ListeClients.Font = new System.Drawing.Font("TeamViewer15", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             Btn_ListeClients.Location = new System.Drawing.Point(12, 12);
             Btn_ListeClients.Name = "Btn_ListeClients";
             Btn_ListeClients.Size = new System.Drawing.Size(126, 38);
             Btn_ListeClients.TabIndex = 0;
             Btn_ListeClients.Text = "Liste";
             Btn_ListeClients.UseVisualStyleBackColor = true;
             Btn_ListeClients.Click += new System.EventHandler(this.Btn_ListeClients_Click);
            // 
            // Btn_AjouterClient
            // 
            this.Btn_AjouterClient.Font = new System.Drawing.Font("TeamViewer15", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AjouterClient.Location = new System.Drawing.Point(157, 12);
            this.Btn_AjouterClient.Name = "Btn_AjouterClient";
            this.Btn_AjouterClient.Size = new System.Drawing.Size(126, 38);
            this.Btn_AjouterClient.TabIndex = 0;
            this.Btn_AjouterClient.Text = "Ajouter";
            this.Btn_AjouterClient.UseVisualStyleBackColor = true;
            this.Btn_AjouterClient.Click += new System.EventHandler(this.Btn_AjouterClient_Click);
            // 
            // Btn_ModifierClient
            // 
            this.Btn_ModifierClient.Font = new System.Drawing.Font("TeamViewer15", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ModifierClient.Location = new System.Drawing.Point(300, 12);
            this.Btn_ModifierClient.Name = "Btn_ModifierClient";
            this.Btn_ModifierClient.Size = new System.Drawing.Size(126, 38);
            this.Btn_ModifierClient.TabIndex = 0;
            this.Btn_ModifierClient.Text = "Modifier";
            this.Btn_ModifierClient.UseVisualStyleBackColor = true;
            this.Btn_ModifierClient.Click += new System.EventHandler(this.Btn_ModifierClient_Click);
            // 
            // Btn_SupprimerClient
            // 
            this.Btn_SupprimerClient.Font = new System.Drawing.Font("TeamViewer15", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SupprimerClient.Location = new System.Drawing.Point(445, 12);
            this.Btn_SupprimerClient.Name = "Btn_SupprimerClient";
            this.Btn_SupprimerClient.Size = new System.Drawing.Size(126, 38);
            this.Btn_SupprimerClient.TabIndex = 0;
            this.Btn_SupprimerClient.Text = "Supprimer";
            this.Btn_SupprimerClient.UseVisualStyleBackColor = true;
            this.Btn_SupprimerClient.Click += new System.EventHandler(this.Btn_SupprimerClient_Click);
            // 
            // Btn_DesactiverClient
            // 
            this.Btn_DesactiverClient.Font = new System.Drawing.Font("TeamViewer15", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DesactiverClient.Location = new System.Drawing.Point(590, 12);
            this.Btn_DesactiverClient.Name = "Btn_DesactiverClient";
            this.Btn_DesactiverClient.Size = new System.Drawing.Size(126, 38);
            this.Btn_DesactiverClient.TabIndex = 0;
            this.Btn_DesactiverClient.Text = "Desactiver";
            this.Btn_DesactiverClient.UseVisualStyleBackColor = true;
            this.Btn_DesactiverClient.Click += new System.EventHandler(this.Btn_DesactiverClient_Click);
            // 
            // p_client
            // 
            this.p_client.BackColor = System.Drawing.Color.Beige;
            this.p_client.Location = new System.Drawing.Point(0, 56);
            this.p_client.Name = "p_client";
            this.p_client.Size = new System.Drawing.Size(1454, 592);
            this.p_client.TabIndex = 1;
            // 
            // AccueilClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(1453, 647);
            this.ControlBox = false;
            this.Controls.Add(this.p_client);
            this.Controls.Add(this.Btn_DesactiverClient);
            this.Controls.Add(this.Btn_SupprimerClient);
            this.Controls.Add(this.Btn_ModifierClient);
            this.Controls.Add(this.Btn_AjouterClient);
            this.Controls.Add( Btn_ListeClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccueilClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AccueilClient";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_AjouterClient;
        private System.Windows.Forms.Button Btn_ModifierClient;
        private System.Windows.Forms.Button Btn_SupprimerClient;
        private System.Windows.Forms.Button Btn_DesactiverClient;
        private System.Windows.Forms.Panel p_client;
        public static System.Windows.Forms.Button Btn_ListeClients;
    }
}