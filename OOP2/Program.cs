using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esra Özdoğan
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.CustomerName = "Esra";
            customer1.CustomerSurname = "Özdoğan";
            customer1.TcNo = "12345678910";


            //Kodlama

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama";
            customer2.TaxNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
