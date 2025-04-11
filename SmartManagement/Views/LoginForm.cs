using System;
using System.Windows.Forms;
using SmartManagement.Controllers;
using SmartManagement.Services;

namespace SmartManagement.Views
{
    public partial class LoginForm : Form
    {
        private UserController _userController;

        public LoginForm()
        {
            InitializeComponent();

            // Création de l'instance d'AuthService
            AuthService authService = new AuthService();

            // Passer l'instance authService au constructeur de UserController
            _userController = new UserController(authService);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string motDePasse = txtMotDePasse.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez entrer votre nom d'utilisateur et votre mot de passe.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var authService = new AuthService();
                var user = authService.Authenticate(login, motDePasse);

                MessageBox.Show($"Bienvenue {user.Nom} !");
                // Tu peux rediriger vers une autre fenêtre ici
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string motDePasse = txtMotDePasse.Text;

            // Appel à AuthenticateUser pour vérifier l'utilisateur
            var user = _userController.AuthenticateUser(login, motDePasse);
            if (user != null)
            {
                // Si l'utilisateur est authentifié, ouvrir MainForm
                MainForm mainForm = new MainForm(user); // Passer l'utilisateur authentifié
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Ferme l'application si LoginForm est fermé
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
