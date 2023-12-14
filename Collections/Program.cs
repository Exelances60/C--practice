using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {

        private static void ArrayListDemo()
        {
            ArrayList cityList = new ArrayList();
            cityList.Add("New York");
            cityList.Add("London");
            cityList.Add("Mumbai");
            cityList.Add("Chicago");

            foreach (var item in cityList)
            {
                Console.WriteLine(item);
            }
        }
        private static void ArrayListDemo2()
        {
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");

            foreach (var item in cities)
            {
                Console.WriteLine(item);

            }
        }
        private static void ArrayListDemo3()
        {
            // ArrayListDemo();
            // ArrayListDemo2();
            //List<Customer> customers = new List<Customer>();
            // customers.Add(new Customer { ID = 1, Name = "Mark" });

            // foreach (var customer in customers)
            // {
            //     Console.WriteLine(customer.ID);
            //     Console.WriteLine(customer.Name);
            // }

            List<Customer> customers = new List<Customer>
            {
                new Customer { ID = 1, Name = "Mark" },
                new Customer { ID = 2, Name = "Pam" }
            };
            var count = customers.Count;
            var customer2 = new Customer { ID = 3, Name = "John" };
            customers.Add(customer2);
            customers.AddRange(new Customer[]
            {
                new Customer { ID = 4, Name = "Rob" },
                new Customer { ID = 5, Name = "Maria" }
            });

            Console.WriteLine("Count : {0}", count);

            customers.Contains(customer2); // Aradıgımız deger listede varmı diye kontrol eder varsa true yoksa false done r
            customers.Exists(c => c.Name.StartsWith("M")); // M ile baslayan isimleri bulur
            customers.Find(c => c.ID == 1); // ID si 1 olanı bulur
            customers.FindAll(c => c.ID > 1); // ID si 1 den buyuk olanları bulur
            customers.FindIndex(c => c.ID == 1); // ID si 1 olanın indexini bulur
            customers.IndexOf(customer2); // customer2 nin indexini bulur
            customers.LastIndexOf(customer2); // customer2 nin son indexini bulur
            customers.Remove(customer2); // customer2 yi siler
            customers.Insert(0, customer2); // 0. indexe customer2 yi ekler
            customers.RemoveAll(c => c.Name.StartsWith("M")); // M ile baslayan isimleri siler
        }

        static void Main(string[] args)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("C#", "Good");
            dictionary.Add("Java", "Average");
            dictionary.Add("Python", "Bad");

            Console.WriteLine(dictionary["C#"]);

            dictionary.ContainsKey("C#"); // C# keyi varmı diye kontrol eder


            Console.ReadLine();
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
