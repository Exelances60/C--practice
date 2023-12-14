using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManeger productManeger=new ProductManeger();
            productManeger.Add();
            productManeger.Update();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Enes",
                LastName = "Çelik",
                Email = "enescelik6012@gmail.com",
                Phone = "0535 000 00 00",
                PhoneNumber = "0535 000 00 00",
                Address = "İstanbul",
                City = "İstanbul"
            };

            Customer customer2=new Customer
            {
                FirstName = "Ali",
                LastName = "Çelik",
                Id = 2,
                Email = "",
                City = "Tokat",
            };

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);




            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}
