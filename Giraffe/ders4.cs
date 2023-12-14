using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class ders4
    {
        public static void GettinUserInput(){
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Enter your age: ");
            int age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
        
            
        }
    }
}
