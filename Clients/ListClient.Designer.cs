namespace Gestion_Stock.Clients
{
    partial class ListClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
             g_listClient = new System.Windows.Forms.DataGridView();
            this.DeleteClient = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(g_listClient)).BeginInit();
            this.SuspendLayout();
            // 
            // g_listClient
            // 
            g_listClient.AllowUserToAddRows = false;
            g_listClient.AllowUserToDeleteRows = false;
            g_listClient.AllowUserToOrderColumns = true;
            g_listClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            g_listClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            DeleteClient});
            g_listClient.Dock = System.Windows.Forms.DockStyle.Fill;
            g_listClient.Location = new System.Drawing.Point(0, 0);
            g_listClient.Name = "g_listClient";
            g_listClient.Size = new System.Drawing.Size(800, 450);
            g_listClient.TabIndex = 0;
            g_listClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.g_listClient_CellClick);
            g_listClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.g_listClient_CellContentClick);
            g_listClient.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.g_listClient_RowsRemoved);
            g_listClient.SelectionChanged += new System.EventHandler(this.g_listClient_SelectionChanged);
            g_listClient.Click += new System.EventHandler(this.g_listClient_Click);
            // 
            // DeleteClient
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteClient.DefaultCellStyle = dataGridViewCellStyle1;
            this.DeleteClient.FalseValue = "false";
            this.DeleteClient.HeaderText = "Supprimer";
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.TrueValue = "true";
            // 
            // ListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(g_listClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListClient";
            this.Text = "ListClient";
            this.Load += new System.EventHandler(this.ListClient_Load);
            ((System.ComponentModel.ISupportInitialize)(g_listClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public static System.Windows.Forms.DataGridView g_listClient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeleteClient;
    }
}