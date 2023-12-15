using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (EtradeContext context = new EtradeContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();

            }
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            if(min > max)
            {
                MessageBox.Show("Min price can not be greater than max price!");
                return GetAll();
            }

            if(min == max)
            {
                return GetAll().Where(p => p.UnitPrice == min).ToList();
            }

            if(min < 0 || max < 0)
            {
                MessageBox.Show("Prices can not be negative!");
                return GetAll();
            }

            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();

            }
        }

        public Product GetById(int id)
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.Products.FirstOrDefault(p => p.Id == id); //FirstOrDefault bulamazsa null döner. ilk bulduğunu getirir. SingleOrDefault birden fazla varsa hata verir.

            }
        }
    }
}
