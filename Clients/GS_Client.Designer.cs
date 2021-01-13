namespace Gestion_Stock.Clients
{
    partial class GS_Client
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
            this.Name_client = new System.Windows.Forms.TextBox();
            this.Client_annuler = new System.Windows.Forms.Button();
            this.Client_Save = new System.Windows.Forms.Button();
            this.Nom_client_label = new System.Windows.Forms.Label();
            this.LastName_client = new System.Windows.Forms.TextBox();
            this.prenom_client_label = new System.Windows.Forms.Label();
            this.address_client = new System.Windows.Forms.TextBox();
            this.Pays_client = new System.Windows.Forms.TextBox();
            this.Mail_client = new System.Windows.Forms.TextBox();
            this.Phone_client = new System.Windows.Forms.TextBox();
            this.raisonSocial_client = new System.Windows.Forms.TextBox();
            this.Name_client_label_erreur = new System.Windows.Forms.Label();
            this.LastName_client_label_erreur = new System.Windows.Forms.Label();
            this.address_client_label_erreur = new System.Windows.Forms.Label();
            this.pays_client_label_erreur = new System.Windows.Forms.Label();
            this.mail_client_label_erreur = new System.Windows.Forms.Label();
            this.Phone_client_label_erreur = new System.Windows.Forms.Label();
            this.raisonSocial_client_label_erreur = new System.Windows.Forms.Label();
            this.addrese_client_label = new System.Windows.Forms.Label();
            this.telephone_client_label = new System.Windows.Forms.Label();
            this.email_client_label = new System.Windows.Forms.Label();
            this.ville_client_label = new System.Windows.Forms.Label();
            this.rs_client_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_client
            // 
            this.Name_client.AccessibleDescription = "string";
            this.Name_client.AutoCompleteCustomSource.AddRange(new string[] {
            "badr",
            "test",
            "anas",
            "hamid"});
            this.Name_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Name_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Name_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_client.Location = new System.Drawing.Point(175, 73);
            this.Name_client.MaxLength = 100;
            this.Name_client.MinimumSize = new System.Drawing.Size(200, 50);
            this.Name_client.Name = "Name_client";
            this.Name_client.Size = new System.Drawing.Size(200, 26);
            this.Name_client.TabIndex = 3;
            this.Name_client.Tag = "string";
            // 
            // Client_annuler
            // 
            this.Client_annuler.Location = new System.Drawing.Point(596, 358);
            this.Client_annuler.Name = "Client_annuler";
            this.Client_annuler.Size = new System.Drawing.Size(126, 31);
            this.Client_annuler.TabIndex = 1;
            this.Client_annuler.Text = "Annuler";
            this.Client_annuler.UseVisualStyleBackColor = true;
            // 
            // Client_Save
            // 
            this.Client_Save.Location = new System.Drawing.Point(464, 358);
            this.Client_Save.Name = "Client_Save";
            this.Client_Save.Size = new System.Drawing.Size(126, 31);
            this.Client_Save.TabIndex = 1;
            this.Client_Save.Text = "Sauve";
            this.Client_Save.UseVisualStyleBackColor = true;
            this.Client_Save.Click += new System.EventHandler(this.Client_Save_Click);
            // 
            // Nom_client_label
            // 
            this.Nom_client_label.AutoSize = true;
            this.Nom_client_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_client_label.Location = new System.Drawing.Point(36, 81);
            this.Nom_client_label.Name = "Nom_client_label";
            this.Nom_client_label.Size = new System.Drawing.Size(45, 18);
            this.Nom_client_label.TabIndex = 2;
            this.Nom_client_label.Text = "Nom";
            // 
            // LastName_client
            // 
            this.LastName_client.AccessibleDescription = "string";
            this.LastName_client.AutoCompleteCustomSource.AddRange(new string[] {
            "badr",
            "test",
            "anas",
            "hamid"});
            this.LastName_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LastName_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.LastName_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_client.Location = new System.Drawing.Point(175, 105);
            this.LastName_client.MaxLength = 100;
            this.LastName_client.MinimumSize = new System.Drawing.Size(200, 26);
            this.LastName_client.Name = "LastName_client";
            this.LastName_client.Size = new System.Drawing.Size(200, 26);
            this.LastName_client.TabIndex = 3;
            this.LastName_client.Tag = "string";
            // 
            // prenom_client_label
            // 
            this.prenom_client_label.AutoSize = true;
            this.prenom_client_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_client_label.Location = new System.Drawing.Point(36, 113);
            this.prenom_client_label.Name = "prenom_client_label";
            this.prenom_client_label.Size = new System.Drawing.Size(69, 18);
            this.prenom_client_label.TabIndex = 2;
            this.prenom_client_label.Text = "Prenom";
            // 
            // address_client
            // 
            this.address_client.AccessibleDescription = "string";
            this.address_client.AutoCompleteCustomSource.AddRange(new string[] {
            "badr",
            "test",
            "anas",
            "hamid"});
            this.address_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.address_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.address_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_client.Location = new System.Drawing.Point(175, 137);
            this.address_client.MaxLength = 100;
            this.address_client.MinimumSize = new System.Drawing.Size(200, 26);
            this.address_client.Name = "address_client";
            this.address_client.Size = new System.Drawing.Size(200, 26);
            this.address_client.TabIndex = 3;
            this.address_client.Tag = "string";
            // 
            // Pays_client
            // 
            this.Pays_client.AutoCompleteCustomSource.AddRange(new string[] {
            "badr",
            "test",
            "anas",
            "hamid"});
            this.Pays_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Pays_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Pays_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pays_client.Location = new System.Drawing.Point(175, 169);
            this.Pays_client.MaxLength = 100;
            this.Pays_client.MinimumSize = new System.Drawing.Size(200, 26);
            this.Pays_client.Name = "Pays_client";
            this.Pays_client.Size = new System.Drawing.Size(200, 26);
            this.Pays_client.TabIndex = 3;
            this.Pays_client.Tag = "string";
            // 
            // Mail_client
            // 
            this.Mail_client.AutoCompleteCustomSource.AddRange(new string[] {
            "badr",
            "test",
            "anas",
            "hamid"});
            this.Mail_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Mail_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Mail_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_client.Location = new System.Drawing.Point(175, 201);
            this.Mail_client.MaxLength = 100;
            this.Mail_client.MinimumSize = new System.Drawing.Size(200, 26);
            this.Mail_client.Name = "Mail_client";
            this.Mail_client.Size = new System.Drawing.Size(200, 26);
            this.Mail_client.TabIndex = 3;
            this.Mail_client.Tag = "string";
            // 
            // Phone_client
            // 
            this.Phone_client.AutoCompleteCustomSource.AddRange(new string[] {
            "badr",
            "test",
            "anas",
            "hamid"});
            this.Phone_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Phone_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Phone_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_client.Location = new System.Drawing.Point(175, 233);
            this.Phone_client.MaxLength = 100;
            this.Phone_client.MinimumSize = new System.Drawing.Size(200, 26);
            this.Phone_client.Name = "Phone_client";
            this.Phone_client.Size = new System.Drawing.Size(200, 26);
            this.Phone_client.TabIndex = 3;
            this.Phone_client.Tag = "string";
            // 
            // raisonSocial_client
            // 
            this.raisonSocial_client.AutoCompleteCustomSource.AddRange(new string[] {
            "badr",
            "test",
            "anas",
            "hamid"});
            this.raisonSocial_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.raisonSocial_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.raisonSocial_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raisonSocial_client.Location = new System.Drawing.Point(175, 265);
            this.raisonSocial_client.MaxLength = 100;
            this.raisonSocial_client.MinimumSize = new System.Drawing.Size(200, 26);
            this.raisonSocial_client.Name = "raisonSocial_client";
            this.raisonSocial_client.Size = new System.Drawing.Size(200, 26);
            this.raisonSocial_client.TabIndex = 3;
            this.raisonSocial_client.Tag = "string";
            // 
            // Name_client_label_erreur
            // 
            this.Name_client_label_erreur.AutoSize = true;
            this.Name_client_label_erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_client_label_erreur.ForeColor = System.Drawing.Color.Red;
            this.Name_client_label_erreur.Location = new System.Drawing.Point(414, 81);
            this.Name_client_label_erreur.Name = "Name_client_label_erreur";
            this.Name_client_label_erreur.Size = new System.Drawing.Size(0, 13);
            this.Name_client_label_erreur.TabIndex = 2;
            // 
            // LastName_client_label_erreur
            // 
            this.LastName_client_label_erreur.AutoSize = true;
            this.LastName_client_label_erreur.ForeColor = System.Drawing.Color.Red;
            this.LastName_client_label_erreur.Location = new System.Drawing.Point(414, 113);
            this.LastName_client_label_erreur.Name = "LastName_client_label_erreur";
            this.LastName_client_label_erreur.Size = new System.Drawing.Size(0, 13);
            this.LastName_client_label_erreur.TabIndex = 2;
            // 
            // address_client_label_erreur
            // 
            this.address_client_label_erreur.AutoSize = true;
            this.address_client_label_erreur.Location = new System.Drawing.Point(414, 145);
            this.address_client_label_erreur.Name = "address_client_label_erreur";
            this.address_client_label_erreur.Size = new System.Drawing.Size(35, 13);
            this.address_client_label_erreur.TabIndex = 2;
            this.address_client_label_erreur.Text = "label1";
            // 
            // pays_client_label_erreur
            // 
            this.pays_client_label_erreur.AutoSize = true;
            this.pays_client_label_erreur.Location = new System.Drawing.Point(414, 177);
            this.pays_client_label_erreur.Name = "pays_client_label_erreur";
            this.pays_client_label_erreur.Size = new System.Drawing.Size(35, 13);
            this.pays_client_label_erreur.TabIndex = 2;
            this.pays_client_label_erreur.Text = "label1";
            // 
            // mail_client_label_erreur
            // 
            this.mail_client_label_erreur.AutoSize = true;
            this.mail_client_label_erreur.Location = new System.Drawing.Point(414, 209);
            this.mail_client_label_erreur.Name = "mail_client_label_erreur";
            this.mail_client_label_erreur.Size = new System.Drawing.Size(35, 13);
            this.mail_client_label_erreur.TabIndex = 2;
            this.mail_client_label_erreur.Text = "label1";
            // 
            // Phone_client_label_erreur
            // 
            this.Phone_client_label_erreur.AutoSize = true;
            this.Phone_client_label_erreur.Location = new System.Drawing.Point(414, 241);
            this.Phone_client_label_erreur.Name = "Phone_client_label_erreur";
            this.Phone_client_label_erreur.Size = new System.Drawing.Size(35, 13);
            this.Phone_client_label_erreur.TabIndex = 2;
            this.Phone_client_label_erreur.Text = "label1";
            // 
            // raisonSocial_client_label_erreur
            // 
            this.raisonSocial_client_label_erreur.AutoSize = true;
            this.raisonSocial_client_label_erreur.Location = new System.Drawing.Point(414, 273);
            this.raisonSocial_client_label_erreur.Name = "raisonSocial_client_label_erreur";
            this.raisonSocial_client_label_erreur.Size = new System.Drawing.Size(35, 13);
            this.raisonSocial_client_label_erreur.TabIndex = 2;
            this.raisonSocial_client_label_erreur.Text = "label1";
            // 
            // addrese_client_label
            // 
            this.addrese_client_label.AutoSize = true;
            this.addrese_client_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrese_client_label.Location = new System.Drawing.Point(36, 141);
            this.addrese_client_label.Name = "addrese_client_label";
            this.addrese_client_label.Size = new System.Drawing.Size(74, 18);
            this.addrese_client_label.TabIndex = 2;
            this.addrese_client_label.Text = "Addrese";
            // 
            // telephone_client_label
            // 
            this.telephone_client_label.AutoSize = true;
            this.telephone_client_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone_client_label.Location = new System.Drawing.Point(36, 237);
            this.telephone_client_label.Name = "telephone_client_label";
            this.telephone_client_label.Size = new System.Drawing.Size(91, 18);
            this.telephone_client_label.TabIndex = 2;
            this.telephone_client_label.Text = "Telephone";
            // 
            // email_client_label
            // 
            this.email_client_label.AutoSize = true;
            this.email_client_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_client_label.Location = new System.Drawing.Point(36, 205);
            this.email_client_label.Name = "email_client_label";
            this.email_client_label.Size = new System.Drawing.Size(53, 18);
            this.email_client_label.TabIndex = 2;
            this.email_client_label.Text = "Email";
            // 
            // ville_client_label
            // 
            this.ville_client_label.AutoSize = true;
            this.ville_client_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ville_client_label.Location = new System.Drawing.Point(36, 173);
            this.ville_client_label.Name = "ville_client_label";
            this.ville_client_label.Size = new System.Drawing.Size(44, 18);
            this.ville_client_label.TabIndex = 2;
            this.ville_client_label.Text = "Ville";
            // 
            // rs_client_label
            // 
            this.rs_client_label.AutoSize = true;
            this.rs_client_label.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rs_client_label.Location = new System.Drawing.Point(36, 269);
            this.rs_client_label.Name = "rs_client_label";
            this.rs_client_label.Size = new System.Drawing.Size(116, 18);
            this.rs_client_label.TabIndex = 2;
            this.rs_client_label.Text = "Raison social";
            // 
            // GS_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.ControlBox = false;
            this.Controls.Add(this.raisonSocial_client_label_erreur);
            this.Controls.Add(this.Phone_client_label_erreur);
            this.Controls.Add(this.mail_client_label_erreur);
            this.Controls.Add(this.pays_client_label_erreur);
            this.Controls.Add(this.address_client_label_erreur);
            this.Controls.Add(this.LastName_client_label_erreur);
            this.Controls.Add(this.rs_client_label);
            this.Controls.Add(this.ville_client_label);
            this.Controls.Add(this.email_client_label);
            this.Controls.Add(this.telephone_client_label);
            this.Controls.Add(this.addrese_client_label);
            this.Controls.Add(this.prenom_client_label);
            this.Controls.Add(this.Name_client_label_erreur);
            this.Controls.Add(this.Nom_client_label);
            this.Controls.Add(this.Client_Save);
            this.Controls.Add(this.Client_annuler);
            this.Controls.Add(this.raisonSocial_client);
            this.Controls.Add(this.Phone_client);
            this.Controls.Add(this.Mail_client);
            this.Controls.Add(this.Pays_client);
            this.Controls.Add(this.address_client);
            this.Controls.Add(this.LastName_client);
            this.Controls.Add(this.Name_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GS_Client";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Tag = "string";
            this.Text = "GS_Client";
            this.Load += new System.EventHandler(this.GS_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_client;
        private System.Windows.Forms.Button Client_annuler;
        private System.Windows.Forms.Button Client_Save;
        private System.Windows.Forms.Label Nom_client_label;
        private System.Windows.Forms.TextBox LastName_client;
        private System.Windows.Forms.Label prenom_client_label;
        private System.Windows.Forms.TextBox address_client;
        private System.Windows.Forms.TextBox Pays_client;
        private System.Windows.Forms.TextBox Mail_client;
        private System.Windows.Forms.TextBox Phone_client;
        private System.Windows.Forms.TextBox raisonSocial_client;
        private System.Windows.Forms.Label Name_client_label_erreur;
        private System.Windows.Forms.Label LastName_client_label_erreur;
        private System.Windows.Forms.Label address_client_label_erreur;
        private System.Windows.Forms.Label pays_client_label_erreur;
        private System.Windows.Forms.Label mail_client_label_erreur;
        private System.Windows.Forms.Label Phone_client_label_erreur;
        private System.Windows.Forms.Label raisonSocial_client_label_erreur;
        private System.Windows.Forms.Label addrese_client_label;
        private System.Windows.Forms.Label telephone_client_label;
        private System.Windows.Forms.Label email_client_label;
        private System.Windows.Forms.Label ville_client_label;
        private System.Windows.Forms.Label rs_client_label;
    }
}