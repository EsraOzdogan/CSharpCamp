using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>(); //string,int vs istediğini verebilirsin T çünkü. Product da verilebilir.
            names.Add("Engin"); // string olduğu için string değer verilecek.

            List<string> list= new List<string>();
            Console.WriteLine(list.Count);


            Console.WriteLine(names.Length);

            names.Add("Kerem");

            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
