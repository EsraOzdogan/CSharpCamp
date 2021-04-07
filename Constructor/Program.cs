using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer1 = new Customer { Id = 1, FirstName = "Esra", LastName = "Özdoğan", City = "İstanbul" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Esra";

            Customer customer2 = new Customer(2, "Ünal", "Özdoğan", "İstanbul");
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        //constructor sınıfı newlediğimizde çalışmasını istediğimiz kodları koyuyoruz.Bu özellik barındıran class. Bir de operasyon yapanlar var add,update vs
        public Customer() //customer,customer1 ve customer3 için
        {
            //boş olsa hiçbir şey çıkmaz.yukada nesne oluşunca burası çalışır
            Console.Write("Ran the contructors");
        }
        //contructor
        public Customer(int id,string firsName,string lastName, string city) //customer2 icin
        {
            Id = id;
            FirstName = firsName;
            LastName = lastName;
            City = city;

        }
        //interface aslında
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}
