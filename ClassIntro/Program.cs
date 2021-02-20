using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();  // tipi Kurs olan kurs1 değişkeni
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();  // tipi Kurs olan kurs1 değişkeni
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();  // tipi Kurs olan kurs1 değişkeni
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.izlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.izlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }    //3 tane özellik

        public string Egitmen { get; set; }

        public int izlenmeOrani { get; set; }
    }
}
