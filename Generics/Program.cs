using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        class Product : IEntity
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        interface IProduct
        {
            List<Product> GetAll();
            Product Get(int id);
            void Add(Product product);
            void Delete(Product product);
        }

        class Customer : IEntity
        {
            public string FirstName { get; set; }
        }

        interface ICustomer
        {
            List<Customer> GetAll();
            Customer Get(int id);
            void Add(Customer customer);
            void Delete(Customer customer);
        }

        //interface IStudent :IRepository<string> // string ile çalışmaz çünkü newlenemez. 
        //{

        //}
   
        interface IEntity
        {

                
        }

        interface IRepository<T> where T: class , IEntity , new() // T sadece referans tip olabilir ve newlenebilir olmalı. new her zaman en sona koyulmalı
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);
        }
     
        interface IProductDal : IRepository<Product>
        {
            //Product ile ilgili özel operasyonlar varsa buraya yazılır.

        }

        class Utility
        {
            public List<T> BuildList<T>(params T[] items) //params ile istediğimiz kadar parametre gönderebiliriz.
            {
                return new List<T>(items);
            }
        }






        static void Main(string[] args)
        {
            Utility utility = new Utility();
            List<int> list = utility.BuildList(1, 2, 3, 4, 5, 6);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            List<Customer> customers = utility.BuildList(new Customer
            {
                FirstName = "Engin"
            },new Customer
            {
                FirstName = "Derin"
            }); 
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }
}
