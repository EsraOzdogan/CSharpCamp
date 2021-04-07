using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName="Esra"
                }, new Student{
                    FirstName="Enes"
                }, new Person{
                   FirstName="Esra"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    //interface birden fazla alınır, ama inheritance  1 tane alır
    //Bir ikiişin bir kez ebeveyni olur ama birden fazla implementasyon yapılır

    //class ise inheritance, interface ise implements
    class Customer : Person
    {
        public string City { get; set; }

    }
    class Student : Person
    {
        public string Departman { get; set; }

    }
}
