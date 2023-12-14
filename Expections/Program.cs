using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expections
{
    internal class Program
    {
        private static void HandleExpection(Action action)
        {
           
            try
            {
                action.Invoke();
            }
            catch (Exception expection)
            {
                Console.WriteLine(expection.Message);
            }
        }
        private static void Find()
        {
            try
            {
                List<string> student = new List<string>
                  {
                "Enes","Ali","Veli"
                   };
                if (!student.Contains("Ahmet"))
                {
                    throw new RecordNotFoundExpection("Record Not Found");

                }
                else
                {
                    Console.WriteLine("Record Found");
                }
            }
            catch (RecordNotFoundExpection expection)
            {
                Console.WriteLine(expection.Message);
            }
        }

        static void Main(string[] args)
        {
          

            HandleExpection(() =>
            {
               Find();
            });

            Console.ReadLine();
        }
    }
}
