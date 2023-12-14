using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();

            string sentence = "My Name is Ömür Kurt";

            var result = sentence.Length; // kaç karakter oldugnu sayar
            var result2 = sentence.Clone(); // metni klonlar
            var result3 = sentence.EndsWith("t"); // metnin hangi harf ile bitip bitmedginin kontrol eder
            var result4 = sentence.StartsWith("M"); // hangi harf ile başladıgını kontrol eder
            var result5 = sentence.IndexOf("Name"); // metnin içinde arar
            var result6 = sentence.IndexOf(" ");    // buldugu ilk boşluk sonrasına bakmaz
            var result7 = sentence.LastIndexOf("    "); // aramaya sondan başlar
            var result8 = sentence.Insert(0,"HELLO");// bir metnin ekleme yapar
            var result9 = sentence.Substring(3);    // 3 karakterden itibaren al (3,4) dersek arasın alır
            var result10 = sentence.ToLower();  // metni küçültmeye
            var result11 = sentence.ToUpper();  // metni büyütme
            var result12 = sentence.Replace(" " , "--");  // metnin içindeki karakterlei degiştirmek için kulanılır
            var result13 = sentence.Remove(2);  // verilen den itibaren siler (2,5) gibide kulanılır arsındaini alır
 
            Console.WriteLine(result10);

            Console.ReadLine();
        }

        private static void Intro()
        {
            String city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)

            {
                Console.WriteLine(item);
            }

            String city2 = "İstanbul";
            //String result = city + city2;

            Console.WriteLine(String.Format("{0} {1}", city, city2));
            
        }
    }
}
