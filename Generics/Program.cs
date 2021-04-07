using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //genericslerde hangi tipi verirsen operasyonlar o tipte çalısır 

            List<string> sehirler = new List<string>(); //List<int> yazsan operasyona int vermek zorundasın biz hangi tipi verirsek o olmasını istiyoruz
            //Console.WriteLine(sehirler.Count);
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
           // Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");

            Console.WriteLine(sehirler2.Count);

        }
    }
    class MyList<T>{ //Generic class
        T[] _array;
        T[] _tempArray; //array sayısını arttırırken arrayın referansını tutan dizi

        public MyList() 
        {
            _array = new T[0];
        
        }
        

       public void Add(T item) //array sayısını bir arttrıyoruz bizim oluşturduğumuz MyList'in
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;

        }

        public int Count //Oluşturduğumuz MyList listesinin sayısını hesaplıyor
        {
            get { return _array.Length; }
        }

    }
}
