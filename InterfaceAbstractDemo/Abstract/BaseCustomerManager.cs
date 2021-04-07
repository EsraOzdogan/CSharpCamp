using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService //save hem starbucks hem de nero için aynı olduğu için abstract sınıf olarak ortak yazıyoruz be interfacei alıyoruz tabii ki

    {
        public virtual void Save(Customer customer) //virtual yerine başka kod yazılabilir managerlarda yani
        {
            Console.WriteLine("Saved To Db" + customer.FirstName);
        }
    }
}
