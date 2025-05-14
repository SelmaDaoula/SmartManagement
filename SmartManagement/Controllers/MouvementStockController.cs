using System;
using System.Collections.Generic;
using System.Linq;
using SmartManagement.Models;
using SmartManagement.Services;

namespace SmartManagement.Controllers
{
    public class MouvementStockController
    {
        private readonly MouvementStockService _service;

        public MouvementStockController(MouvementStockService service)
        {
            _service = service;
        }

        public void AddMouvement(string type, int quantite, int produitId)
        {
            try
            {
                // Ajouter le mouvement
                _service.AddMouvement(type, quantite, produitId);

                // Afficher les statistiques après l'ajout du mouvement
                AfficherStatistiques();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'ajout du mouvement: {ex.Message}");
            }
        }

        public List<MouvementStock> GetAllMouvements()
        {
            return _service.GetAllMouvements();
        }

        private void AfficherStatistiques()
        {
            // Afficher le produit le plus vendu aujourd'hui
            var produitsAujourdhui = _service.GetTopProduitAujourdhui();
            Console.WriteLine("Produit le plus vendu aujourd'hui :");
            foreach (var produit in produitsAujourdhui)
            {
                Console.WriteLine($"{produit.ProduitNom} : {produit.QuantiteVendue} ventes");
            }

            // Afficher le produit le plus vendu cette semaine
            var produitsSemaine = _service.GetTopProduitSemaine();
            Console.WriteLine("Produit le plus vendu cette semaine :");
            foreach (var produit in produitsSemaine)
            {
                Console.WriteLine($"{produit.ProduitNom} : {produit.QuantiteVendue} ventes");
            }

            // Afficher le produit le plus vendu le mois dernier
            var produitsMoisDernier = _service.GetTopProduitMoisDernier();
            Console.WriteLine("Produit le plus vendu le mois dernier :");
            foreach (var produit in produitsMoisDernier)
            {
                Console.WriteLine($"{produit.ProduitNom} : {produit.QuantiteVendue} ventes");
            }
        }
    }
}
