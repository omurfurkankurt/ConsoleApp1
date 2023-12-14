using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            // List();

            //anahtar kelime kulanarak onun degerine ulaşmak için kulanılır
            // istedgimiz veri tipini verebiliriz
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("compter", "bilgiseyar");

          //  Console.WriteLine(dictionary["table"]); // bu şekilde kulanabiliriz
          //  Console.WriteLine(dictionary["glas"]); // false degeri döndürür böyle bir anahtar olamdıgı için

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);     // foreach kulanarak tüm degerleri döndürebiliriz
                Console.WriteLine(item.Value); // bu şekilde degere 
                Console.WriteLine(item.Key); // bu şekilde de sadece anahtara ulaşabiliriz
            }

           Console.WriteLine( dictionary.ContainsKey("glass")); // sende glass diye bişey varmı diye soru sorabiliriz
            Console.WriteLine(dictionary.ContainsValue("tablo"));


            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();  // verdigmiz veritürü dışında başka türde veri giremeyiz
            cities.Add("Ankara");
            cities.Add("İstanbul");
            Console.WriteLine(cities.Contains("Ankara"));  // listenin içinde arama yapmamıza yarar 

            foreach (var city in cities)
            {
                Console.WriteLine(city);

            }



            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, Name = "ömür" });
            //customers.Add(new Customer { Id = 2, Name = "Engin" });

            // aşagıdaki şekildede yazılabilir

            List<Customer> customers = new List<Customer>
            {
                new Customer() {Id = 1, Name= "ömür"},
                new Customer() {Id = 2,Name= "Engin"}

            };


            var customer1 = new Customer
            {
                Id = 1,
                Name = "Ömür"
            };

            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 3,Name ="furkan"},
                new Customer {Id = 4,Name =" Kurt"}
            });

            // customers.Clear(); // liste içinde bulunan elamanalaerı siler



            Console.WriteLine(customers.Contains(new Customer { Id = 1, Name = "Ömür" }));
            // burda newledgmiz için degerlerle işimiz yok referans newledigmiz zman degişecegi için false döner


            var index = customers.IndexOf(customer1);  // listenin başından başlayarak index numarasını verir 
            Console.WriteLine("Index {0}", index);

            customers.Add(customer1);

            var index2 = customers.LastIndexOf(customer1);  // lsitenşn sonundan başlayak index numarsını verir
            Console.WriteLine("Index2 {0}", index2);

            customers.Insert(0, customer1); // listede index numarasını verek istedgmiz yere ekleme yapmamızı saglar



            customers.Remove(customer1);  // istedignin veriyi listeden silmek için kulanılır 1 tanesini buldugu anda aramayı bırakır

            //  customers.RemoveAll(c =>c.Name == "Ömür"); // ama bunu kulandıgmız zaman ismi ömür olan tüm verileri siler


            foreach (var customer in customers)

            {
                // Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);

            }

            var Count = customers.Count;  // listenin kaç elamanlı oldugnu bulur
            Console.WriteLine(" Count = {0}", Count);
        }

        private static void ArrayList()
        {

            //string[] cities = new string[2] { "Ankara", "İstanbul"};
            //cities = new string[3];  // dedigmiz zaman bellekte yeni bir 3 karakterlik alan oluşturur ama içinde veri olmaz 
            //Console.WriteLine(cities[0]);



            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);

            }

            //  Console.WriteLine(cities[2]);
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }




}
