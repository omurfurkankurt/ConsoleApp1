﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Aadded by default");

            }

            public abstract void Delete();

        }

        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by defaultSql ");
            }
        }
        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by oracle ");


            }
        }
    }
}
