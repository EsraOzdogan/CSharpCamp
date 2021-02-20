using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array - dizi

            string[] kurslar = new string[] { kurs1,
                "Programlamaya başlangıç için temel kurs",
                "Java", "Python", "C#" };

           /* for (int i = 0; i < 10; i++)  //i=i+2
            {
                Console.WriteLine(i);
            }*/

            for (int i = 0; i < kurslar.Length; i++)  //i=i+2
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)  //kursları dolaş, foreach dizileri dolaşır.Yukardaki for ile aynı işlemi yapıyor.
            {
                Console.WriteLine(kurs); 
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
