using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //tüm krediler bu interface içindeki fonksiyonlara uymak zorunda
    //interfaceler birbirine benzeyen ama farklı kod içerikleri için kullanılır.
    interface ICreditManager //okunurluğu arttırmak için I konulur interfacesin başına
    {
        void Calculate();
        void BiseyYap();
    }
}
