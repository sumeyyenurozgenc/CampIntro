using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Id = 1;
            p1.CategoryId = 2; //Mobilya = 2
            p1.ProductName = "Masa";
            p1.UnitPrice = 500;
            p1.UnitsInStock = 3;

            Product p2 = new Product { Id = 1, CategoryId = 5, ProductName = "Kalem", UnitPrice = 500, UnitsInStock = 3 };

            ProductManager productManager = new ProductManager();
            productManager.Add(p1);
        }
    }
}
