using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(20);
            customerManager.list();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product1 = new Product(2, "compter");         // diger kulanımı hiç deger vermesekte olur


            //  EmployeeManager employeeManager = new EmployeeManager();
            //  employeeManager.Logger = new Logger();


            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();


            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            Utilities.Validate();  // static clasları newlemeden çağırabilirsiniz
            Manager.DoSomething();
            Manager manager = new Manager();  // statc olan dirk sınıf üzerinden çagırılabilir olmayan ise Inheritance (miras sınıfk katılım) kulanılarak cagırılır
            manager.DoSomething2();
            Console.ReadLine();

        }
    }
    class CustomerManager
    {
        private int _count = 15;   // burda deger verip yukarıda dger vermesek burdaki degeri alır ama yukarıda deger verdigmiz zaman yukardaki degeri alır
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void list()
        {
            Console.WriteLine("Listed {0}", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }

    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;

        }

        public int Id { get; set; }
        public string Name { get; set; }

    }

    interface ILogger
    {
        void Log();
    }


    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
    //class EmployeeManager
    //{
    //    public ILogger Logger { get; set; } 
    //    public void Add()
    //    {
    //        Logger.Log();   
    //        Console.WriteLine("ADDED!");
    //    }
    //}



    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("ADDED!");
        }
    }

    class BaseClass
    {
        private String _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} masage", _entity);
        }

    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("ADDED!");
            Message();
        }

    }

    static class Utilities
    {



        public static void Validate()
        {
            Console.WriteLine("Validation is done");

        }
    }





    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }


        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }

}
