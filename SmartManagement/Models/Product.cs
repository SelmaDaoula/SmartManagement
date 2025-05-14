using System.ComponentModel.DataAnnotations;

namespace SmartManagement.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }  // The database will automatically increment this field.
        public string Nom { get; set; }
        public int QuantiteStock { get; set; }
        public decimal PrixUnitaire { get; set; }
        public int SeuilAlerte { get; set; }

        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
    }
}
