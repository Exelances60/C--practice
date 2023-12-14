using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_ile_çalışma
{
    internal class Program
    {
        private static bool IsPrimeNumber(int number)
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi=Convert.ToInt32(Console.ReadLine());
             
            if (IsPrimeNumber(sayi))
            {
                Console.WriteLine("Sayı asaldır");
            }
            else
            {
                Console.WriteLine("Sayı asal değildir");
            }


            Console.ReadLine();
        }
    }
}  
