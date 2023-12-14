using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] city = new string[]
            {
                "İstanbul",
                "Ankara",
                "İzmir"

            };
            
            DataTable dataTable = new DataTable();
            dataTable.LoadDataRow(city, true);

        foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
