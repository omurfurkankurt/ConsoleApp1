 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

         

            DataTable dataTable;  // Newlemye gerk yok çünkü referans tipleri ile çalışıyor nwelweme bellekte çok yer kaplar  
            DataTable dataTable1 = new DataTable();
            dataTable=dataTable1;


            Console.ReadLine();






        }
    }
}
