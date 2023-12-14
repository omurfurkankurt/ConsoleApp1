using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //pirvate sadece tanımladıgmız blok içinde geçerlidir
    // pirivate bir degşkeni özellik metod  protected  olarak tanımlarsak kendi bloğ
    // hariç başka blokalarda inheritance aldıgı taktirde erişmek mümkündür.
    // internal olark tanımlarsak proje icindeki her hangi bir dosyadan erişmek mümkündür
    //  public farklı bir projeden erişmek isterek bir calssa onu public olarak tanımalrız
    // ve kulanacagmız projenin referansarından kulancagmız zlasın oldugu projeyi seçer ve 
    // kulancagmız dosyanın başında using yazark erişmek istedgimzi classın ulundugu projenin ismini yazarız
    class Customer
    {
        protected int Id { get; set; }
          
        public void save()
        {

        }

        public void Delete()
        {

        }

    }
    class student : Customer
    {
        public void save2()
        {
            Id++;

        }
    }


    internal class Course
    {
        public string Name { get; set; }
    }
    public class Course1
    {
        public string Name { get; set; }
    }


}
