using SmartManagement.Models;
using SmartManagement.Services;
using System;
using System.Collections.Generic;

namespace SmartManagement.Controllers
{
    public class ProductController
    {
        private readonly ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public List<dynamic> GetAllProduits()
        {
            return _productService.GetAllProduits();
        }

        public void AddProduct(Product newProduct)
        {
            ValidateProduct(newProduct);
            _productService.AddProduct(newProduct);
        }

        public void UpdateProduct(Product updatedProduct)
        {
            ValidateProduct(updatedProduct);
            _productService.UpdateProduct(updatedProduct);
        }

        private void ValidateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            if (string.IsNullOrWhiteSpace(product.Nom))
                throw new ArgumentException("Le nom du produit ne peut pas être vide.");

            if (product.QuantiteStock < 0)
                throw new ArgumentException("La quantité ne peut pas être négative.");

            if (product.PrixUnitaire < 0)
                throw new ArgumentException("Le prix ne peut pas être négatif.");

            if (product.CategorieId <= 0)
                throw new ArgumentException("Catégorie invalide.");

            if (product.SeuilAlerte < 0)
                throw new ArgumentException("Le seuil d’alerte ne peut pas être négatif.");
        }
        public void DeleteProduct(int productId)
        {
            if (productId <= 0)
                throw new ArgumentException("ID de produit invalide.");

            _productService.DeleteProduct(productId);
        }

    }
}
