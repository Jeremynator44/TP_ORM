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
            bsClients.DataSource = Modele.listeClients(); // appel de la m�thode listeClients
            dgvClients.DataSource = bsClients;
            dgvClients.Columns[0].Visible = false;

            bsPartitions.DataSource = Modele.listePartitions(); // appel de la m�thode listeClients
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
            // nomComplet est la concat�nation du nom et pr�nom issu de la requ�te suivante
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
    }
}
