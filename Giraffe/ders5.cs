using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class ders5
    {
         public static void BasicCalculator()
        {
            Console.Write("Enter a Number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operator :");
            string operatior = Console.ReadLine();
            Console.Write("Enter a Number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch(operatior)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                case "%":
                    Console.WriteLine(num1 % num2);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }


        }

    }
}
