using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
       

        public List<Product> GetAll()
        {   // newlemk belekte çok yer kapladıgı için using kulanarak blok bitigi anda
            // nesneyi belketen atmayı saglar using kulanmasakta kod calışır ama bellkete fazlada yer 
            // kaplanmış olur
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();

            }

        }
        public List<Product> GetByName(String key)
        {   // newlemk belekte çok yer kapladıgı için using kulanarak blok bitigi anda
            // nesneyi belketen atmayı saglar using kulanmasakta kod calışır ama bellkete fazlada yer 
            // kaplanmış olur
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();

            }

        }
        public List<Product> GetByUnitPrice(decimal min , decimal max)
        {   
            using (ETradeContext context = new ETradeContext())
            {
              var result = context.Products.Where(p => p.UnitPrice >= min &&p.UnitPrice<max).ToList();
              
              return result;
            }
            
            
        }
       

        public Product GetById(int id)
        { 
            using (ETradeContext context = new ETradeContext())
            {
                var result = context.Products.FirstOrDefault(p => p.Id == id);
                return result;
            }

        } 
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
               context.Products.Add(product);
                context.SaveChanges();

            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
    }
}
