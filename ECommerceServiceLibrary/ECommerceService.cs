using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceServiceLibrary
{
    public class ECommerceService : IECommerceService
    {
        // KONFIGURACJA BAZY DANYCH
        private ECommerceDbContext dbContext;
        public ECommerceService()
        {
            dbContext = new ECommerceDbContext();
        }

        // CRUD

        public List<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return dbContext.Products.Find(productId);
        }

        public void AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = dbContext.Products.Find(product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                dbContext.SaveChanges();
            }
            else
            {
                throw new ArgumentException($"Produkt o ID: {product.ProductId} nie znaleziony.");
            }
        }

        public void DeleteProduct(int productId)
        {
            var productToDelete = dbContext.Products.Find(productId);
            if (productToDelete != null)
            {
                dbContext.Products.Remove(productToDelete);
                dbContext.SaveChanges();
            }
        }

        public bool PlaceOrder(Order order)
        {
            // Implementacja logiki składania zamówienia.
            return true;
        }

        public User GetUserDetails(int userId)
        {
            // Implementacja logiki pobierania szczegółów użytkownika.
            return new User { UserId = userId, Username = "User", Email = "user@example.com" };
        }
    }
}
