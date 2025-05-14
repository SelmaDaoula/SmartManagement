namespace SmartManagement.Models  
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Nom { get; set; }  // Change "Name" en "Nom" si tu veux utiliser "Nom"
        public List<Product> Produits { get; set; }
    }
}


