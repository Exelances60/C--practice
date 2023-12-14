using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManger customerManger = new CustomerManger();
               customerManger.Logger = new DatabaseLogger();
             customerManger.Add();


            Console.ReadLine();
        }
    }

    interface ILogger
    {
        void Log();
    }
    class CustomerManger
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }

    class DatabaseLogger:ILogger
    {

        public void Log()
        {
            Console.WriteLine("Logged to Database " );
        }

      
    }
    class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged the File");
        }

     
    }
}
