using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Gender = "Erkek";
            p1.Brand = "Mavi";
            p1.ProductName = "Sweatshirt";
            p1.AboutProduct = "Siyah Fermuarlı Sweatshirt";
            p1.Price = 49.99;

            Product p2 = new Product();
            p2.Gender = "Kadın";
            p2.Brand = "TrendyolMilla";
            p2.ProductName = "Sweatshirt";
            p2.AboutProduct = "Vişne Çürüğü Örme Sweatshirt";
            p2.Price = 79.99;

            Product p3 = new Product();
            p3.Gender = "Erkek";
            p3.Brand = "Lc Waikiki";
            p3.ProductName = "Pantolon";
            p3.AboutProduct = "Erkek Siyah Kanvas Slim Fit Dar Kesim";
            p3.Price = 89.99;

            Product[] allProduct = new Product[] { p1, p2, p3 };
            for (int i = 0; i < allProduct.Length; i++)
            {
                Console.WriteLine(allProduct[i].Gender + "\n" + allProduct[i].Brand + " " + allProduct[i].ProductName + " " + allProduct[i].AboutProduct + "\n" + allProduct[i].Price + " TL");
                Console.WriteLine("------");
            }
            Console.WriteLine("\n\n");

            foreach (var product in allProduct)
            {
                Console.WriteLine(product.Gender + "\n" + product.Brand + " " + product.ProductName + " " + product.AboutProduct + "\n" + product.Price + " TL");
                Console.WriteLine("------");
            }
            Console.WriteLine("\n\n");

            int length = 0;
            while (length < allProduct.Length)
            {
                Console.WriteLine(allProduct[length].Gender + "\n" + allProduct[length].Brand + " " + allProduct[length].ProductName + " " + allProduct[length].AboutProduct + "\n" + allProduct[length].Price + " TL");
                Console.WriteLine("------");
                length++;
            }
        }
    }

    class Product
    {
        public string Gender { get; set; }
        public string Brand { get; set; }
        public string ProductName { get; set; }
        public string AboutProduct { get; set; }
        public double Price { get; set; }
    }
}
