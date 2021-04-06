using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esra Özdoğan
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerNo = "123456";
            customer1.FirstName = "Esra";
            customer1.LastName = "Özdoğan";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerNo = "654321";
            customer2.FirstName = "Ünal";
            customer2.LastName = "Özdoğan";
            customer2.City = "İstanbul";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.WriteLine(" \n");

            Customer[] customers = new Customer[] { customer1, customer2 };
            customerManager.ListCustomer(customers);

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);


            Console.ReadLine();
        }
    }
}
