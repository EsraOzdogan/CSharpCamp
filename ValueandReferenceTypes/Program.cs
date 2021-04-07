using System;

namespace ValueandReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //  int,decimal ,float, double , bool =  deger tip (stack)

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            //sayi1 =10 30
            //sayi2 =30 65

            //  array, class ,interface = referans tip (heap)

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; //adresi atadı aslında degeri atanmıyor
            sayilar2[0] = 999;
            //sayilar1[0] 999


            //101 adres- sayilar1 = [10, 20, 30]- garbage 
            //102 adres-sayilar2 = [100, 200, 300]- [999, 200,300]

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Esra";

            person2 = person1;
            person1.FirstName = "Ünal";

            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Suzan";
            customer.CreditCardNumber = "123456";

            Employee employee = new Employee();
            employee.FirstName = "Enes";

            //person customer ve employeenin adresini tutuyor
            Person person3 = customer;
            customer.FirstName = "Enes";
            //Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);

            //  int,decimal ,float, double , bool =  deger tip (stack)
            //  array, class ,interface = referans tip (heap)
        }
    }
    //base class Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }


    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
