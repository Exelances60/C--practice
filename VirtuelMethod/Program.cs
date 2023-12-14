using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuelMethod
{
    class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }
    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by MySql");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
        
            SqlServer sqlServer1 = new SqlServer();
            sqlServer1.Add();
            sqlServer1.Delete();



            Console.ReadKey();
        }

    }

}
