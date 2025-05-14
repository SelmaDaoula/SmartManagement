using System.Linq;
using System.Security.Cryptography;
using System.Text;
using SmartManagement.Models;

using System.Linq;

namespace SmartManagement.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;

        public AuthService()
        {
            _context = new AppDbContext();
        }

        // Méthode d'authentification
        public User Authenticate(string login, string motDePasse)
        {
            if (_context == null)
                throw new InvalidOperationException("Le contexte de la base de données n'a pas été initialisé.");

            // Vérifier d'abord si le login existe
            var user = _context.Users.FirstOrDefault(u => u.Login == login);

            if (user == null)
            {
                throw new Exception("Login incorrect"); // Spécifique au login
            }

            // Si le login existe, vérifier le mot de passe
            if (user.MotDePasse != motDePasse)
            {
                throw new Exception("Mot de passe incorrect"); // Spécifique au mot de passe
            }

            return user;
        }

    }

}
