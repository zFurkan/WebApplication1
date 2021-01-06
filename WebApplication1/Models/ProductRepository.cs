using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class ProductRepository
    {
        private static List<Product> _product;

        static ProductRepository()
        {
            _product = new List<Product>()
            {
                new Product() { Name = "T1", Description = "Siyah", Category = "Benzin", Price = 100000 },
                        new Product() { Name = "X10", Description = "Beyaz", Category = "Dizel", Price = 150000 },
                        new Product() { Name = "AB1", Description = "Beyaz", Category = "Dizel", Price = 95000 }
            };
        }

        public static List<Product> Products
        {
            get { return _product; }
        }

        public static void AddProduct(Product entity)
        {
            _product.Add(entity);
        }

    }
}

