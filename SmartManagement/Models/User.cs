using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManagement.Models
{
    public class User
    {
        [Key]
        public int IdUtilisateur { get; set; } // Identifiant unique de l'utilisateur

        [Required]
        public string Nom { get; set; } // Nom de l'utilisateur

        [Required]
        [MaxLength(100)]
        public string Login { get; set; } // Identifiant (nom d'utilisateur ou email)

        [Required]
        public string MotDePasse { get; set; } // Mot de passe de l'utilisateur

        // Lien avec la classe Role (un utilisateur a un rôle)
        public int RoleId { get; set; } // Clé étrangère vers la table Role
        public Role Role { get; set; }  // Navigation vers le rôle
    }
}
