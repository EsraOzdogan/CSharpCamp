using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    { 
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Id : " + customer.Id + "  " +
               "Customer No : " + customer.CustomerNo + "  " + "Customer First Name : " + customer.FirstName + "  " +
               "Customer Last Name : " + customer.LastName + "  " +
               "Customer City : " + customer.City + " " + "customer added");
        }
        public void Delete(Customer customer)
        {

            Console.WriteLine("Customer Id : " + customer.Id + "  " +
               "Customer No : " + customer.CustomerNo + "  " + "Customer First Name : " + customer.FirstName + "  " +
               "Customer Last Name : " + customer.LastName + "  " +
               "Customer City : " + customer.City + " " + "customer deleted");
        }


        public void ListCustomer(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Id : " + customer.Id + "  " +
              "Customer No : " + customer.CustomerNo + "  " + "Customer First Name : " + customer.FirstName + "  " +
              "Customer Last Name : " + customer.LastName + "  " +
              "Customer City : " + customer.City + " " );
            }
            Console.WriteLine("\n");
        }

      



    }
}
