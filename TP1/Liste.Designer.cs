namespace TP1
{
    partial class Liste
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bsClients = new BindingSource(components);
            dgvClients = new DataGridView();
            dgvCommandes = new DataGridView();
            bsCommandes = new BindingSource(components);
            cbClients = new ComboBox();
            bsClients2 = new BindingSource(components);
            btn_Afficher = new Button();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(197, 286);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.Size = new Size(591, 152);
            dgvClients.TabIndex = 0;
            // 
            // dgvCommandes
            // 
            dgvCommandes.AllowUserToAddRows = false;
            dgvCommandes.AllowUserToDeleteRows = false;
            dgvCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCommandes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandes.Location = new Point(196, 12);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.ReadOnly = true;
            dgvCommandes.Size = new Size(592, 268);
            dgvCommandes.TabIndex = 1;
            // 
            // cbClients
            // 
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(12, 12);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(169, 23);
            cbClients.TabIndex = 2;
            // 
            // bsClients2
            // 
            bsClients2.CurrentChanged += BsClients2_CurrentChanged;
            // 
            // btn_Afficher
            // 
            btn_Afficher.Location = new Point(12, 412);
            btn_Afficher.Name = "btn_Afficher";
            btn_Afficher.Size = new Size(169, 26);
            btn_Afficher.TabIndex = 3;
            btn_Afficher.Text = "Tout Afficher";
            btn_Afficher.UseVisualStyleBackColor = true;
            btn_Afficher.Click += btn_Afficher_Click;
            // 
            // Liste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Afficher);
            Controls.Add(cbClients);
            Controls.Add(dgvCommandes);
            Controls.Add(dgvClients);
            Name = "Liste";
            Text = "Fenêtre";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsClients;
        private DataGridView dgvClients;
        private DataGridView dgvCommandes;
        private BindingSource bsCommandes;
        private ComboBox cbClients;
        private BindingSource bsClients2;
        private Button btn_Afficher;
    }
}
