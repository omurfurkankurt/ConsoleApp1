﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //TryCatch();

            //ActionDemo();

            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1,100);
            };

            Func<int> getRandomNumber2=()=>new Random().Next(1,100);


            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());

            // Console.WriteLine(Topla(2,3));

            Console.ReadLine();
        }

        static int Topla (int x ,int y)
        {
            return x + y;   
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {

                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }

            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (Exception exception)
            {

            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin ", "Salih","Ahmet" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not found"); // kendi hata mesajımızı oluşturup son kulanıcıya bilgi verdik
            }

            else
            {
                Console.WriteLine("Record  Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                // try Bu kdu dene çalışmadıgı taktirde catch çalıştır
                string[] students = new string[3] { "Engin", "Derin", "Salih"};

                students[3] = "Ahmet";

            }
            catch (IndexOutOfRangeException exception) // bu şekilde eger aldıgmız hata bu ise blogu çalıştır anlamına gelir
            {
                Console.WriteLine(exception.Message);
            }


            catch (Exception exception)
            {
                Console.WriteLine(exception.Message); // bu şekilde hatanın mesajını alabilirir ama kulanıcı hatanın sebebini görmesin diy kendi veri tabanımıza loglarız


            }
        }
    }
}
