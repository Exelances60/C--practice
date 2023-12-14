using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Method
    {
        static void Add()
        {
            Console.WriteLine("Enter a number: ");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add();
            Console.ReadLine();
        }

    }
}
