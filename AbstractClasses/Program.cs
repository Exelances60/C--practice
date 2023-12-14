using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Database
    {
        public  void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
