using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        class Person
        {
            public int id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }

        class Student : Customer
        {
            public string Department { get; set; }
        }

        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person { FirstName = "Ali", LastName = "Veli", id = 1 },
                new Customer { FirstName = "Ayşe", LastName = "Fatma", id = 2, City = "İstanbul" },
                new Student { FirstName = "Mehmet", LastName = "Ahmet", id = 3, Department = "Computer Science",City="Türkiye" }
            };

            foreach (Person person in people)
            {
                Console.WriteLine(person.FirstName);
            }
     
            Console.ReadLine();

        }
    }
}

