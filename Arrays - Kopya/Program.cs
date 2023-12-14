﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];

            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Saalih";


            string[] students2 = { "Engin", "Derin", "salih" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);

            }
            Console.WriteLine();
            //Console.ReadLine();

            string[,] regions = new string[5, 3]
            {
                { "istanbul","izmit","balıkesir"},
                { "Ankara","konya","kırıklareli"},
                { "antalya", "adana","mersin"},
                { "rize","trabzon","samsun"},
                { "izmir","mugla","manisa"}

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine((regions[i, j]));
                }
                Console.WriteLine("*********");

            }

            string ilkögrenci = students2[0];

            Console.WriteLine(ilkögrenci);

            Console.ReadLine();


        }
    }
}