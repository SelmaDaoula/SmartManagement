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
            // Vérifiez si _context est null
            if (_context == null)
            {
                throw new InvalidOperationException("Le contexte de la base de données n'a pas été initialisé.");
            }

            var user = _context.Users.FirstOrDefault(u => u.Login == login && u.MotDePasse == motDePasse);

            // Vérifiez si l'utilisateur est null
            if (user == null)
            {
                throw new InvalidOperationException("Aucun utilisateur trouvé avec ces identifiants.");
            }

            return user;
        }
    }

}
