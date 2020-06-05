using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationASPNET_Cloud.Models
{
    public class Product
    {
        readonly int id;
        readonly string name;
        readonly decimal price;
        readonly string department;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public decimal Price { get { return price; } }
        public string Department { get { return department; } }

        public Product(int id, string name, decimal price, string department)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.department = department;
        }

        Product() { }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
                       {
                           new Product(id:1, name: "Remote Car", price:9.99m, department:"Toys"),
                           new Product(id:2, name: "Boll Pen", price:2.99m, department:"Stationary"),
                           new Product(id:3, name: "Teddy Bear", price:6.99m, department:"Toys"),
                           new Product(id:4, name: "Tennis Boll", price:6.99m, department:"Toys"),
                           new Product(id:5, name: "Super Man", price:6.99m, department:"Toys"),
                           new Product(id:6, name: "Bikes", price:4.99m, department:"Toys"),
                           new Product(id:7, name: "Books", price:7.99m, department:"Stationary"),
                           new Product(id:8, name: "Mobiles", price:5.99m, department:"Toys"),
                           new Product(id:9, name: "Laptops", price:15.99m, department:"Toys"),
                           new Product(id:10, name: "Note Books", price:2.99m, department:"Stationary")
                       };
        }
    }
}
