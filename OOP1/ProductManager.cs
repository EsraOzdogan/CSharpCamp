using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)//101         //Sonucunda bir şey yapılmadığı için void
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " added.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");
        }
       /* public  void BiseyYap(int sayi)//100
        {
            sayi = 99;
        }*/

        /*public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+ sayi2);
        }*/
    }
}
