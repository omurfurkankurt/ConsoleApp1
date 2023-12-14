using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerMAnager customerMAnager = new CustomerMAnager();
            customerMAnager.Add();
            Console.ReadLine(); 
        }
    }

    class CustomerMAnager
    {
        public void Add()
        {
           CustomerManageer customerManageer = new CustomerManageer();
            customerManageer.Logger=new SmsLogger();
 
            customerManageer.Add();
            Console.ReadLine() ;

        }
    }

  class CustomerManageer
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.log();
            Console.WriteLine("Customer Added!");
        }
    }




    class DatabaseLogger:ILogger
    {
        public void log ()
        {
            Console.WriteLine("Logged to Database!");
        }
    }

    class FileLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
    class SmsLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }
    interface ILogger
    {
        void log();
    }
    class MyClass
    {

    }
}
