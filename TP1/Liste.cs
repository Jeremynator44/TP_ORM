using TP1.Entities;
using TP1.MODELE;

namespace TP1
{
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsClients.DataSource = Modele.listeClients(); // appel de la méthode listeClients
            dgvClients.DataSource = bsClients;
            dgvClients.Columns[0].Visible = false;

            bsPartitions.DataSource = Modele.listePartitions(); // appel de la méthode listeClients
            dgvPartitions.DataSource = bsPartitions;

            bsPartitionsStyle.DataSource = Modele.listeStyle().Select(x => new
            {
                x.Numstyle,
                x.Libstyle,
            });
            dgvPartitionsStyle.DataSource = bsPartitionsStyle;

            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvCommandes.DataSource = bsCommandes;

            cbClients.ValueMember = "NUMCLI";
            cbClients.DisplayMember = "nomComplet";
            // nomComplet est la concaténation du nom et prénom issu de la requête suivante
            bsClients2.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            });
            cbClients.DataSource = bsClients2;


            cbStyle.ValueMember = "NUMSTYLE";
            cbStyle.DisplayMember = "Libstyle";
            bsStyle.DataSource = (Modele.listeStyle()).Select(x => new
            {
                x.Numstyle,
                x.Libstyle
            });
            cbStyle.DataSource = bsStyle;
        }

        private void BsClients2_CurrentChanged(object sender, EventArgs e)
        {
            int IDC = Convert.ToInt32(cbClients.SelectedValue);
            int IdClient = Convert.ToInt32(cbClients.SelectedValue);
            bsCommandes.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            })
                .OrderBy(x => x.Datecde);
            dgvCommandes.DataSource = bsCommandes;
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            bsCommandes.DataSource = Modele.listeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvCommandes.DataSource = bsCommandes;

            bsPartitionsStyle.DataSource = Modele.listePartitions().Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.Numstyle
            });
            dgvPartitionsStyle.DataSource = bsPartitionsStyle;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int Montant = Convert.ToInt32(txtMontant.Text);
            bsCommandes.DataSource = Modele.listeCommandesParMontant(Montant).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvCommandes.DataSource = bsCommandes;
        }

        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {
            int Style = Convert.ToInt32(cbStyle.SelectedValue);
            bsPartitionsStyle.DataSource = Modele.listePartitionParStyle(Style).Select(x => new
            {
                x.Numpart,
                x.Libpart,
                x.Prixpart,
                x.Numstyle
            });
            dgvPartitionsStyle.DataSource = bsPartitionsStyle;
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            GestionCommandes gestionCommandes = new GestionCommandes();
            gestionCommandes.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            System.Type type = bsCommandes.Current.GetType();
            int idCommande = (int)type.GetProperty("Numcde").GetValue(bsCommandes.Current, null);
            GestionCommandes gestionCommandes = new GestionCommandes(idCommande);
            gestionCommandes.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            bool rep = false;

            System.Type type = bsCommandes.Current.GetType();
            int idCommande = (int)type.GetProperty("Numcde").GetValue(bsCommandes.Current, null);
            int montant = (int)type.GetProperty("Montantcde").GetValue(bsCommandes.Current, null);
            string nom = (string)type.GetProperty("Nomcli").GetValue(bsCommandes.Current, null);
            string prenom = (string)type.GetProperty("Prenomcli").GetValue(bsCommandes.Current, null);
            DateTime datecde = (DateTime)type.GetProperty("Datecde").GetValue(bsCommandes.Current, null);

            if (MessageBox.Show("Etes vous sur de vouloir supprimer la commande : " + idCommande + " d'un montant de " + montant + "€ et avec le client " + prenom + " " + nom + " à la date du " + datecde, "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                rep = Modele.SuppCommande(idCommande);
                if (rep)
                {
                    MessageBox.Show("upprimer avec succès !!");
                }
                else
                {
                    MessageBox.Show("Echec de la surppression !");
                }
            }
        }
    }
}
