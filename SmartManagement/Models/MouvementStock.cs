using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManagement.Models
{

    public class MouvementStock
    {
        public int Id { get; set; }
        public required string TypeMouvement { get; set; }// "Entrée" ou "Sortie"
        public int Quantite { get; set; }
        public DateTime Date { get; set; }

        public int ProduitId { get; set; }
        public Product Produit { get; set; }
    }
}
