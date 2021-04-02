using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>   //Mylist'te T ile çalışıcam.string,int vs olur. T type yani T olarak ne verirsem istediğim elemanın türü de odur.
    {
        T[] items; //array
        //constructor
        //ctor tab tab
        public MyList()  //0 elemanlı dizi
        {
            items = new T[0];
        }
        //eleman sayısını 1 arttırmam gerekiyor.
        public void Add(T item)  
        {

            T[] tempArray = items; //102
            items = new T[items.Length + 1]; //103  //eleman sayısını 1 arttırmam gerekiyor. newlendiği için referan numarası gitti o yüzden geçici dizi oluştuurulaca temp diye.yukarda

            for (int i = 0; i < tempArray.Length; i++)//temparraydeki değeri geri itemse atıyoruz
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
