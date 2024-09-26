using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Entities;
using TP1.MODELE;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP1
{
    public partial class GestionCommandes : Form
    {
        bool ajout;
        bool modif;
        int Modification;
        public GestionCommandes()
        {
            ajout = true;
            InitializeComponent();
        }
        public GestionCommandes(int Modification)
        {
            modif = true;
            this.Modification = Modification;
            InitializeComponent();
        }

        private void GestionCommandes_Load(object sender, EventArgs e)
        {
            if (ajout)
            {
                cbListeClients.ValueMember = "NUMCLI";
                cbListeClients.DisplayMember = "nomComplet";
                bsListeClients.DataSource = (Modele.listeClients()).Select(x => new
                {
                    x.Numcli,
                    nomComplet = x.Nomcli + " " + x.Prenomcli
                });
                cbListeClients.DataSource = bsListeClients;

                txtMontant.Text = "";
                cbListeClients.SelectedIndex = -1;
                dtPicker.Value = DateTime.Today;
            }
            if (modif)
            {
                Commande commande = Modele.RecupererCommande(Modification);
                txtMontant.Text = commande.Montantcde.ToString();

                cbListeClients.ValueMember = "NUMCLI";
                cbListeClients.DisplayMember = "nomComplet";
                bsListeClients.DataSource = (Modele.listeClients()).Select(x => new
                {
                    x.Numcli,
                    nomComplet = x.Nomcli + " " + x.Prenomcli
                })
                    .Where(x => x.Numcli == commande.Numcli);
                cbListeClients.DataSource = bsListeClients;
                dtPicker.Value = commande.Datecde;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtMontant.Text = "";
            cbListeClients.SelectedIndex = -1;
            dtPicker.Value = DateTime.Today;

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValiderCommande_Click(object sender, EventArgs e)
        {
            bool rep = false;
            
            if (ajout)
            {
                if (txtMontant.Text != "" && Convert.ToInt32(txtMontant.Text) >= 0 && cbListeClients.SelectedIndex != -1)
                {
                    rep = Modele.AjoutCommande(Convert.ToInt32(txtMontant.Text), dtPicker.Value, Convert.ToInt32(cbListeClients.SelectedValue));

                    if (rep)
                    {
                        MessageBox.Show("Ajouter avec succès !!");
                        txtMontant.Text = "";
                        cbListeClients.SelectedIndex = -1;
                        dtPicker.Value = DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show("Echec de l'ajout !");
                    }
                }
                else
                {
                    MessageBox.Show("Le client ou le montant est incorrect !!");
                }
            }
            if (modif)
            {
                if (txtMontant.Text != "" && Convert.ToInt32(txtMontant.Text) >= 0 && cbListeClients.SelectedIndex != -1)
                {                 
                    rep = Modele.ModifCommande(Modification, Convert.ToInt32(txtMontant.Text), dtPicker.Value, Convert.ToInt32(cbListeClients.SelectedValue));

                    if (rep)
                    {
                        MessageBox.Show("Modifier avec succès !!");
                        txtMontant.Text = "";
                        cbListeClients.SelectedIndex = -1;
                        dtPicker.Value = DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show("Echec de la modification !");
                    }
                }
                else
                {
                    MessageBox.Show("Le montant doit être supérieur à 0 !!");
                }
            }
            
            
        }
    }
}
