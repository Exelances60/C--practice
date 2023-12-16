using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        private delegate void MyDelegate(); // 1. elçi tanımladık
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            MyDelegate myDelegate = customerManager.SendMessage; // 2. elçiye metot atadık

            myDelegate();
            Console.WriteLine("-------------");
            myDelegate += customerManager.ShowAlert; // 3. elçiye metot atadık
            myDelegate();

            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }
    }
}
