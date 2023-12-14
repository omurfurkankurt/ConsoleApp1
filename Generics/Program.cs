using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                 
                           // Generic Nedir\\
/*Generic yapılar, farklı veri tipleriyle çalışabilen ve kodunuzu daha esnek, yeniden kullanılabilir hale getiren yapılar sağlar.
Bir Generic yapı, belirli bir veri tipi yerine herhangi bir veri tipiyle çalışabilen sınıflar veya metodlar oluşturmanızı sağlar.
Bu sayede, aynı mantığı farklı veri tipleriyle kullanabilirsiniz ve tip güvenliği sağlarlar.

Örneğin, bir Generic List yapısı oluşturduğunuzda, bu liste herhangi bir veri tipini depolayabilir.
List<int> şeklinde tanımladığınızda, listede sadece tamsayılar depolanabilirken, List<string> şeklinde tanımladığınızda sadece metin dizileri depolanabilir.
Bu yapılar, aynı kodu farklı veri tipleriyle kullanarak tekrar kullanımı artırır ve hataları derleme zamanında tespit etmenize yardımcı olur.

Generic yapılar, algoritma ve veri yapılarının esnek ve genel amaçlı olmasını sağlayarak kodunuzu daha modüler hale getirir.
Bu yapılar, tip güvenliği, kod tekrarı ve daha az tip dönüşümü gibi avantajlar sağlar, böylece yazılım geliştirme sürecini geliştirir.*/

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach(string item in result) 
            {
               Console.WriteLine(item);

            }

            List<Customer>result2 = utilities.BuildList<Customer>(new Customer { FirstName="Engin"},new Customer { FirstName = "Derin  "});
            foreach(Customer customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();

        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items) 
        {
            return new List<T>(items);  
        }
}
    class Product:IEntity
    {

    }

    interface IProductDal:IRepository<Product>
    {
        
    }
    class Customer:IEntity
    {
        public string FirstName { get; set; }

    }
    interface ICustomerDal:IRepository<Customer>
    {
        void Custom();
    }
    interface IStudentDal : IRepository<Customer>
    {

    }
    class Student:IEntity
    {

    }
    interface IEntity
    {

    }
  //  interface IRepository<T> where T : struct // Deger tipler için kulanl
    interface IRepository<T> where T : class,IEntity,new()  

    {
        T Get(int id);
        void Add(T entitiy);
        void Delete(T entitiy);
        void  Update(T entitiy);    
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entitiy)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
