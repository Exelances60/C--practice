using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class ders3
    {
        public static void ders3DataType()
        {
            string phrase = "Giraffe Academy "+ " is cool";
            Console.WriteLine(phrase.Contains("cool"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.Substring(8));
         /* Console.WriteLine("Giraffe\nAcademy");
            Console.WriteLine("Giraffe\"Academy"); */
        }
    }
}
