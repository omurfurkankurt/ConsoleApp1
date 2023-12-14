using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var number = 10;

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }

            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }

            else
            {
                Console.WriteLine("number is not 10");

            }

            var number1 = 11;
            Console.WriteLine(number1 == 10 ? "Number is 10 " : "Number is not 10");

            var number3 = 10;
            switch (number3)
            {
                case 10:
                    Console.WriteLine(" Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20 ");
                    break;
            } 

            Console.ReadLine();
        }
    }
}
