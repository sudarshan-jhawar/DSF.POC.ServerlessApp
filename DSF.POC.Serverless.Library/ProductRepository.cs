using DSF.POC.Serverless.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSF.POC.Serverless.Library
{
    public class ProductRepository
    {
        private static List<Product> Products { get; set; } = new List<Product> {
            new Product(0,"Product 0","Product Description 0"),
            new Product(1,"Product 1","Product Description 1"),
            new Product(2,"Product 2","Product Description 2"),
            new Product(3,"Product 3","Product Description 3"),
        };

        public Task<List<Product>> GetProductsAsync() => Task.FromResult(Products);

        public Task<Product> GetProductByIdAsync(int id) => Task.FromResult(Products.FirstOrDefault(_ => _.ProductId == id) ?? new Product(0, "Product 0", "Product Description 0"));
    }
}
