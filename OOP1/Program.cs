using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //classlar 2ye ayrılır: özellik ve fonksiyon barındıranlar.fonksiyon olanlar 'managerlı'

            Product product1 = new Product(); //101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            //iki şekilde de yazılır.Gerçek hayatta böyle olmuyor.veriden kullanıcıdan vs geliyor.
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //PascalCase- ilk harfler büyük   //camelCase-ilk harf küçük diğer harf büyük
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //kamera


            /*int sayi = 100;
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi); //100*/


            //productManager.Topla2(3,6);

            //int toplamasonucu= productManager.Topla(3,6);
            //Console.WriteLine( toplamasonucu*2);

           
            //int,double,bool... değer tip
            //diziler,class, abstract class, interface ... referans tip
            //ref out

        }
    }
}
