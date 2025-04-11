using System;
using System.Windows.Forms;
using SmartManagement.Models;
using SmartManagement.Services;
using SmartManagement.Views;

namespace SmartManagement.Controllers
{
    public class UserController
    {
        private readonly AuthService _authService;

        // Constructeur qui accepte un AuthService
        public UserController(AuthService authService)
        {
            _authService = authService;
        }

        // Méthode pour authentifier un utilisateur
        public User AuthenticateUser(string login, string motDePasse)
        {
            return _authService.Authenticate(login, motDePasse);
        }
    }
}

