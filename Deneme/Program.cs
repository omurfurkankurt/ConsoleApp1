using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[, ,] matris = new int[2,3,4]
            {
               {
                   { 1, 2, 3, 4 },
                   { 5, 6, 7, 8 },
                   { 9, 10, 11, 12 }
               },
            {
                   { 13, 14, 15, 16 },
                   { 17, 18, 19, 20 },
                   { 21, 22, 23, 24 }
                  }
            };

            int rows = matris.GetLength(0); // Birinci boyut (katman sayısı)
            int columns = matris.GetLength(1); // İkinci boyut (satır sayısı)
            int depth = matris.GetLength(2); // Üçüncü boyut (sütun sayısı)

            for (int k = 0; k < rows; k++) // Katmanlar
            {
                Console.WriteLine("Katman " + (k + 1) + ":");
                for (int i = 0; i < columns; i++) // Satırlar
                {
                    for (int j = 0; j < depth; j++) // Sütunlar
                    {
                        Console.Write(matris[k, i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
