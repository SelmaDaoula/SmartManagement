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
    }
}
