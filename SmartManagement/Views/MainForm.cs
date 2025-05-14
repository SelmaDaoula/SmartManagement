using System;
using System.Windows.Forms;
using SmartManagement.Models;

namespace SmartManagement.Views
{
    public partial class MainForm : Form
    {
        private User _user;

        // Constructeur qui prend un objet User en paramètre
        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Vérifier si l'utilisateur est null
            if (_user == null)
            {
                MessageBox.Show("L'utilisateur est null.");
                return;
            }

            // Afficher les informations de l'utilisateur dans l'interface
            lblUserName.Text = $"Bienvenue, {_user.Nom}";

            // Vérifier si le rôle de l'utilisateur est null
            if (_user.Role == null)
            {
                lblRole.Text = "Rôle : Aucun rôle attribué";
            }
            else
            {
                lblRole.Text = $"Rôle : {_user.Role.Nom}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Console.WriteLine("DashboardButton cliqued");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ReportButton_Click(object sender, EventArgs e)

        {

            // Créer une instance de la fenêtre ProdForm
            MouvementStockForm MouvementStockForm = new MouvementStockForm();

            // Afficher la fenêtre
            MouvementStockForm.Show();
            


        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("AboutButton cliqued");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Fermer le MainForm actuel
            this.Close();

            // Redémarrer l'application
           // Application.Restart();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Your click handling code here
        }
        private void ChartButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ChartButton cliqued");
            Console.WriteLine("ReportButton cliqué");
            ProdForm prodForm = new ProdForm();

            // Afficher la fenêtre
            prodForm.Show();

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SettingsButton cliqued");
        }
        
             private void AdminButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("AdminButton cliqued");
            CategoryForm CategoryForm = new CategoryForm();

            // Afficher la fenêtre
            CategoryForm.Show();
        }

        public void AfficherStatistiques(List<ProduitStatistique> statsJour, List<ProduitStatistique> statsSemaine, List<ProduitStatistique> statsMois)
{
    if (statsJour.Any())
        lblStatJour.Text = $"Aujourd'hui : {statsJour.First().ProduitNom} - {statsJour.First().QuantiteVendue} ventes";
    else
        lblStatJour.Text = "Aujourd'hui : Aucun produit vendu";

    if (statsSemaine.Any())
        lblStatSemaine.Text = $"Semaine : {statsSemaine.First().ProduitNom} - {statsSemaine.First().QuantiteVendue} ventes";
    else
        lblStatSemaine.Text = "Semaine : Aucun produit vendu";

    if (statsMois.Any())
        lblStatMois.Text = $"Mois dernier : {statsMois.First().ProduitNom} - {statsMois.First().QuantiteVendue} ventes";
    else
        lblStatMois.Text = "Mois dernier : Aucun produit vendu";
}


    }
}
