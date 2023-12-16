using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attribuiest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDal = new CustomerDal();
            Customer customer = new Customer
            {
                Id = 1,
                LastName = "Demiroğ",
                Age = 32
            };
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    class Customer 
    {
        public int Id { get; set; }

        [RequirePropertyAttribute]
        public string FirstName { get; set; }
        [RequirePropertyAttribute]

        public string LastName { get; set; }
        public int Age { get; set; }

    }  
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    class RequirePropertyAttribute : Attribute
    {

    }

    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            this._tableName = tableName;
        }
    }

}
