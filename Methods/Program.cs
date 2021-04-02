using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Apple";
            double fiyati = 15;
            string aciklama = "Amasya apple";


            string[] fruits = new string[] { "Apple", "Watermelon" };

            Product product1 = new Product();
            product1.ProductName = "Apple";
            product1.UnitPrice = 15;
            product1.Description = "Amasya apple";

            Product product2 = new Product();
            product2.ProductName = "Watermelon";
            product2.UnitPrice = 80;
            product2.Description = "Diyarbakır watermelon";

            Product[] products = new Product[] { product1, product2 };

            //type-safe -- tip güvenli
            foreach (var product in products)   //2 kere dönücek 2 ürün var. urunler dizi, urun her bir elemanı tanımlamak için değişken
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.Description);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("------------Methods---------------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Pear", "Green pear", 12, 10);    //encapsulation- ayrı ayrı yazılanların bir düzene girmesi
            sepetManager.Add2("Apple", "Green apple", 12, 9);
            sepetManager.Add2("Watermelon", "Diyarbakır watermelon", 12, 8);


        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice

