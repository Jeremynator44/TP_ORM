namespace TP1
{
    partial class GestionCommandes
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
            components = new System.ComponentModel.Container();
            txtMontant = new TextBox();
            dtPicker = new DateTimePicker();
            cbListeClients = new ComboBox();
            btnValiderCommande = new Button();
            btnFermer = new Button();
            btnAnnuler = new Button();
            bsListeClients = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsListeClients).BeginInit();
            SuspendLayout();
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(281, 152);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(167, 23);
            txtMontant.TabIndex = 0;
            // 
            // dtPicker
            // 
            dtPicker.Location = new Point(497, 152);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(200, 23);
            dtPicker.TabIndex = 1;
            // 
            // cbListeClients
            // 
            cbListeClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListeClients.FormattingEnabled = true;
            cbListeClients.Location = new Point(69, 152);
            cbListeClients.Name = "cbListeClients";
            cbListeClients.Size = new Size(167, 23);
            cbListeClients.TabIndex = 2;
            // 
            // btnValiderCommande
            // 
            btnValiderCommande.Location = new Point(497, 235);
            btnValiderCommande.Name = "btnValiderCommande";
            btnValiderCommande.Size = new Size(193, 32);
            btnValiderCommande.TabIndex = 3;
            btnValiderCommande.Text = "Valider";
            btnValiderCommande.UseVisualStyleBackColor = true;
            btnValiderCommande.Click += btnValiderCommande_Click;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(691, 12);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(119, 30);
            btnFermer.TabIndex = 4;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(255, 235);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(193, 32);
            btnAnnuler.TabIndex = 5;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // GestionCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 479);
            Controls.Add(btnAnnuler);
            Controls.Add(btnFermer);
            Controls.Add(btnValiderCommande);
            Controls.Add(cbListeClients);
            Controls.Add(dtPicker);
            Controls.Add(txtMontant);
            Name = "GestionCommandes";
            Text = "Form1";
            Load += GestionCommandes_Load;
            ((System.ComponentModel.ISupportInitialize)bsListeClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMontant;
        private DateTimePicker dtPicker;
        private ComboBox cbListeClients;
        private Button btnValiderCommande;
        private Button btnFermer;
        private Button btnAnnuler;
        private BindingSource bsListeClients;
    }
}