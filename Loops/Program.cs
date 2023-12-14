using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();
            //  WhileLoop();
            // DoWhileLoop();
            //ForEachoop();

            if (IsPirimeNumber(5))
            {
                Console.WriteLine("This is a pirime number ");
            }
            else
            {
                Console.WriteLine("this is a not pirime number");
            }
            Console.ReadLine();
        }
        private static bool IsPirimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;

                }


            }
            return result;
        }



        private static void ForEachoop()
        {
            string[] students = { "Engin", "Derin ", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;

            while (number >= 0)
            {

                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now Number is {0}", number);

        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)      // i+=2 veya i=i+2 gibi kulanımları vardır.

            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Finished!");
        }
    }
}
