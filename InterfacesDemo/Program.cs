using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        //interfaceler new'lenemez
        //çoklu implementasyon

        static void Main(string[] args)
        {
            //interfaceler new'lenemez yani aşağısı çalışmaz, implemente ettiği classlar new'lenir
            //IWorker a = new IWorker();
            //IWorker manager = new Manager();
            //manager.Work();



            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };
            foreach( var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };
        }
    }

    interface IWorker
    {
        //unimplemented operation
        void Work();

    }
    //SOLID, Interface Segregation
    interface IEat
    {

        void Eat();
    }
    interface ISalary
    {
        void GetSalary();

    }

    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {

        }

        public void GetSalary()
        {

        }

        public void Work()
        {
            Console.WriteLine("work");
        }
    }

    class Worker : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
