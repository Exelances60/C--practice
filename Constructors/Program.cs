using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManger customerManger = new CustomerManger(10);
            customerManger.List();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
           

            Console.ReadLine();
        }
    }
    class CustomerManger
    {
        private int _count;
        public CustomerManger(int count)
        {

            _count = count;

        }
        public void List()
        {
            Console.WriteLine("Listed!"+ _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }

    }
    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
            
        }
    }
}
