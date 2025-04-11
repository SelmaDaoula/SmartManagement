using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManagement.Models
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; } // Identifiant unique pour le rôle

        [Required]
        [MaxLength(100)]
        public string Nom { get; set; } // Par exemple : "Admin", "Utilisateur", etc.
    }
}
