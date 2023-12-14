using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //var result = Add2(12, 34);

            int number1 = 20;
            int number2 = 100;
             
            var result = Add3(ref number1, number2);

            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("ADDED !!!!");
        }

        static int Add2(int number1, int number2)   // bu alanda numralaın sonundaki numara ya veya hepsine  deger verilirse ve yukarıda deger girilmese burda verililen degeri alır yukarda verilirse burdakini almaz
        {
            return number1 + number2;

        }

        static int Add3(ref int  number1, int number2 )   // out ve ref aynıdır mantık olarak ama outa number1 deger verveye gerek yoktur amam methodun içinde set edilmesi gerkir
        {
            number1 = 30;
            return number1 + number2;   

        }
    }
}
