using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();


            ////
            // Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new OracleCustomerDal(),
                new SQLServerCustomerDal(),
            };
            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Esra", LastName = "Özdoğan", Address = "İst" });


            Customer customer = new Customer();
            customer.FirstName = "Enes";

            Student student = new Student();
            student.FirstName = "Esra";

            Console.WriteLine(customer);
            Console.WriteLine(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }

        string LastName { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
