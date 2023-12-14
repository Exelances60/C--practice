using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studens=new string[3];
            studens[0] = "Engin";
            studens[1] = "Derin";
            studens[2] = "Salih";

            string[] students2 = { "Engin", "Derin", "Salih" };
            students2[2]="Veli";


            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[7, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                { "Ankara","Konya","Kırşehir"},
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun"},
                { "İzmir","Muğla","Manisa"},
                { "İzmir","Muğla","Manisa"},
                { "İzmir","Muğla","Manisa"}
            };
            for (int i=0; i<=regions.GetUpperBound(0); i++)
            {
                for (int j=0; j<=regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********");
            }   

            Console.ReadLine();
        }
    }
}
