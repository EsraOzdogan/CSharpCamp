﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];   //new denildiği anda bellekte yeni değer oluşur, yeni referans yani.  Yukarıdaki değerler kaybolur.
            //names[4] = "İlker";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]); // boş ggelicek o yüzden.

            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" }; //List yapısı ile 0. indeksi tekrar okuyabilir.
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);

            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);



        }
    }
}