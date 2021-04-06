using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> customerList = new MyDictionary<string,string>();
            customerList.Add("Engin","Demirog");

            MyDictionary<int, string> studentList = new MyDictionary<int, string>();
            studentList.Add(1, "Esra");

            Console.WriteLine(customerList.Count);
            Console.WriteLine(studentList.Count);

            customerList.Add("Engin", "Demirog");
            customerList.Add("Engin", "Demirog");
            customerList.Add("Engin", "Demirog");
            customerList.Add("Engin", "Demirog");

            studentList.Add(1, "Esra");
            studentList.Add(1, "Esra");


            Console.WriteLine(customerList.Count);
            Console.WriteLine(studentList.Count);




        }
    }
}
