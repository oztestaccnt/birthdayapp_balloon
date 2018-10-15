using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HTMLHelpers.Models;

namespace HTMLHelpers.Models
{
    public class Product
    {
        public string id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }


    //public class Category
    //{
    //    public string Id { get; set; }
    //    // and more properties
    //}


    public class ProductContext
    {

        //public Product Product { get; set; }

        public List<Product> GetAll()

        {
            return new List<Product>()
            {
                new Product {id = "100", Name = "Jeans", Price = 59.99},
                new Product {id = "101", Name = "Polo", Price = 49.99}
            };
        }
    }

}



