using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method {

  class Program {
     static int Add(out int number1,int number2) {
             number1 = 30;
             return number1 + number2;
           
    }
     static void Add(int number1)
     {
               Console.WriteLine(number1);
     }
     static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }

    static void Main(string[] args) {
            int number1 = 20;
            int number2 = 100;
            var result = Add(out number1,number2);
            Console.WriteLine(result);
            Add(number1);
            Console.WriteLine(Add(1,2,3,4,5,6,7,8,9));
        }
  }

}