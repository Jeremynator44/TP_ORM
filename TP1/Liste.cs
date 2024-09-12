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
            int IDC = Convert.ToInt32(cbStyle.SelectedValue);
            int Style = Convert.ToInt32(cbStyle.SelectedValue);
            bsStyle.DataSource = Modele.listeStyle().Select(x => new
            {
                x.Libstyle
            });
            dgvPartitionsStyle.DataSource = bsStyle;
        }
    }
}
