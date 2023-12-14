  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IWorker[] workers = new IWorker[3]
            //{
            //    new Manager(),
            //    new Work(),
            //    new robot()
            //};
            //foreach (var worker in workers)
            //{
            //    worker.Work();

            //}

            IEat[] eats = new IEat[2];
            {
              
            }

        }
    }

    //interface IWorker
    //{
    //    void Work();
    //    void Eats();
    //    void GetSalary();


    //}

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();

    }

    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
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
    class Work : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        void IWorker.Work()
        {
            throw new NotImplementedException();
        }
    }
    class robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}