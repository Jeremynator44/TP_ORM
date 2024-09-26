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
            txtMontant = new TextBox();
            btnValider = new Button();
            dgvPartitions = new DataGridView();
            bsPartitions = new BindingSource(components);
            dgvPartitionsStyle = new DataGridView();
            cbStyle = new ComboBox();
            bsStyle = new BindingSource(components);
            bsPartitionsStyle = new BindingSource(components);
            btnAjout = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartitions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPartitions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartitionsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPartitionsStyle).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(12, 12);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.Size = new Size(508, 211);
            dgvClients.TabIndex = 0;
            // 
            // dgvCommandes
            // 
            dgvCommandes.AllowUserToAddRows = false;
            dgvCommandes.AllowUserToDeleteRows = false;
            dgvCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCommandes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCommandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommandes.Location = new Point(11, 229);
            dgvCommandes.Name = "dgvCommandes";
            dgvCommandes.ReadOnly = true;
            dgvCommandes.Size = new Size(509, 236);
            dgvCommandes.TabIndex = 1;
            // 
            // cbClients
            // 
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(526, 12);
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
            btn_Afficher.Location = new Point(526, 406);
            btn_Afficher.Name = "btn_Afficher";
            btn_Afficher.Size = new Size(169, 26);
            btn_Afficher.TabIndex = 3;
            btn_Afficher.Text = "Tout Afficher";
            btn_Afficher.UseVisualStyleBackColor = true;
            btn_Afficher.Click += btn_Afficher_Click;
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(526, 302);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(169, 23);
            txtMontant.TabIndex = 4;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(526, 331);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(169, 23);
            btnValider.TabIndex = 5;
            btnValider.Text = "Valider";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // dgvPartitions
            // 
            dgvPartitions.AllowUserToAddRows = false;
            dgvPartitions.AllowUserToDeleteRows = false;
            dgvPartitions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPartitions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPartitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartitions.Location = new Point(887, 12);
            dgvPartitions.Name = "dgvPartitions";
            dgvPartitions.ReadOnly = true;
            dgvPartitions.Size = new Size(484, 211);
            dgvPartitions.TabIndex = 6;
            // 
            // dgvPartitionsStyle
            // 
            dgvPartitionsStyle.AllowUserToAddRows = false;
            dgvPartitionsStyle.AllowUserToDeleteRows = false;
            dgvPartitionsStyle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPartitionsStyle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPartitionsStyle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartitionsStyle.Location = new Point(887, 229);
            dgvPartitionsStyle.Name = "dgvPartitionsStyle";
            dgvPartitionsStyle.ReadOnly = true;
            dgvPartitionsStyle.Size = new Size(484, 211);
            dgvPartitionsStyle.TabIndex = 7;
            // 
            // cbStyle
            // 
            cbStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStyle.FormattingEnabled = true;
            cbStyle.Location = new Point(712, 229);
            cbStyle.Name = "cbStyle";
            cbStyle.Size = new Size(169, 23);
            cbStyle.TabIndex = 8;
            // 
            // bsStyle
            // 
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(351, 471);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(160, 31);
            btnAjout.TabIndex = 9;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(185, 471);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(160, 31);
            btnModifier.TabIndex = 10;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(19, 471);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(160, 31);
            btnSupprimer.TabIndex = 11;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // Liste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 524);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjout);
            Controls.Add(cbStyle);
            Controls.Add(dgvPartitionsStyle);
            Controls.Add(dgvPartitions);
            Controls.Add(btnValider);
            Controls.Add(txtMontant);
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
            ((System.ComponentModel.ISupportInitialize)dgvPartitions).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPartitions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartitionsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPartitionsStyle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsClients;
        private DataGridView dgvClients;
        private DataGridView dgvCommandes;
        private BindingSource bsCommandes;
        private ComboBox cbClients;
        private BindingSource bsClients2;
        private Button btn_Afficher;
        private TextBox txtMontant;
        private Button btnValider;
        private DataGridView dgvPartitions;
        private BindingSource bsPartitions;
        private DataGridView dgvPartitionsStyle;
        private ComboBox cbStyle;
        private BindingSource bsStyle;
        private BindingSource bsPartitionsStyle;
        private Button btnAjout;
        private Button btnModifier;
        private Button btnSupprimer;
    }
}
