using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.ProductName);
        }

        public void Add2(string ProductName, string Description, double UnitPrice, int UnitsInStock)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + ProductName);
        }
    }
}
