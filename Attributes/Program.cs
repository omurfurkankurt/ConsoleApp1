using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, Lastname = "Demirog", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }

    }

    //[ToTable("Customers")]
    //[ToTable("TblCustomers")]


    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string Firstname { get; set; }
        [RequiredProperty]
        [RequiredProperty]
        public string Lastname { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }



    class CustomerDal
    {
        [Obsolete(" Don't use Add instead AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!", customer.Id, customer.Firstname, customer.Lastname, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} Added!", customer.Id, customer.Firstname, customer.Lastname, customer.Age);

        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true/*| AttributeTargets.Field*/)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToRableAttribute : Attribute
    {
        private string _tableName;
        public ToRableAttribute(string tableName)
        {
            _tableName = tableName;
        }

    }

}
