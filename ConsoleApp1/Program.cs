using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double number5 = 10.4;  // 8 bytes
            decimal number6 = 10.4m; // 16 bytes
            char character = 'a';   // 2 bytes
            string city = "ankara"; // String tipi, metin uzunluğuna bağlı olarak değişken bellek kullanımına sahiptir.
            bool condition = false;  // 1 bytes
            byte number4 = 255;       // 1 byte
            short number3 = 10000;    // 2 bytes
            int number1 = 1000000000; // 4 bytes
            long number2 = 100000000000000000; // 8 bytes
            var number7 = 10;// degişken türünü otomatik algılar
            number7 = 'A'; // asci degeri

            Console.WriteLine("Number1 is {0} ", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("number7 is {0}", number7);
            Console.WriteLine("Character is : {0}",/*(int)*/character); // asci degerini almk için
            Console.WriteLine(/*(int)*/Days.Friday);
            Console.ReadLine();
        }
            enum Days
        {
            Monday, Tuesday, Wednesday,Thursday,Friday,Saturday,Sunday 
             
        }

                   
    }
}
