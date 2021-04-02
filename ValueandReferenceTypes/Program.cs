using System;

namespace ValueandReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            //sayi1 =10 30
            //sayi2 =30 65


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //adresi atadı aslında degeri atanmıyor
            sayilar2[0] = 999;
            //sayilar1[0] 999


            //101 adres- sayilar1 = [10, 20, 30]- garbage 
            //102 adres-sayilar2 = [100, 200, 300]- [999, 200,300]

            //  int,decimal ,float, double , bool =  deger tip (stack)
            //  array, class ,interface = referans tip (heap)
        }
    }
}
