using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { Id = 1, FirstName = "Esra", LastName = "Özdoğan", DateOfBirth = new DateTime(1998,15,1), NationalityId = 1556546 });

            Console.ReadLine();
        }
    }
}
