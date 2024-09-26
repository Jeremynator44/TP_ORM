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
            txtMontant = new TextBox();
            dtPicker = new DateTimePicker();
            cbListeClients = new ComboBox();
            btnValiderCommande = new Button();
            btnFermer = new Button();
            btnAnnuler = new Button();
            SuspendLayout();
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(191, 130);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(167, 23);
            txtMontant.TabIndex = 0;
            // 
            // dtPicker
            // 
            dtPicker.Location = new Point(411, 130);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(200, 23);
            dtPicker.TabIndex = 1;
            // 
            // cbListeClients
            // 
            cbListeClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListeClients.FormattingEnabled = true;
            cbListeClients.Location = new Point(191, 173);
            cbListeClients.Name = "cbListeClients";
            cbListeClients.Size = new Size(167, 23);
            cbListeClients.TabIndex = 2;
            // 
            // btnValiderCommande
            // 
            btnValiderCommande.Location = new Point(411, 235);
            btnValiderCommande.Name = "btnValiderCommande";
            btnValiderCommande.Size = new Size(193, 32);
            btnValiderCommande.TabIndex = 3;
            btnValiderCommande.Text = "Valider";
            btnValiderCommande.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            btnFermer.Location = new Point(691, 12);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(119, 30);
            btnFermer.TabIndex = 4;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(191, 235);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(193, 32);
            btnAnnuler.TabIndex = 5;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
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
    }
}