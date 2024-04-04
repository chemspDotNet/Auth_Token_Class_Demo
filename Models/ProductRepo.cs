using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth_Token_Class_Demo.Models
{
    public class ProductRepo
    {
        static readonly List<Product> products = new List<Product>();

        public ProductRepo()
        {
            for (int i = 101; i <= 125; i++)
            {
                Product p = new Product()
                {
                    Name = i.ToString(),
                    ID = i,
                    Manufacturer = "Manufacturer" + i.ToString(),
                    price = 1000 + i,
                };
                products.Add(p);
            }

        }

        public  List<Product> GetProducts()
        {
            return products;
        }
    }
}