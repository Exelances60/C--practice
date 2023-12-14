using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Int veri Giriniz \n 2-Float Veri geriniz \n 3-Double veri giriniz \n 4-Bool veri giriniz \n 5-string veri giriniz \n 6-object veri giriniz");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    try { 
                    Console.WriteLine("... veri giriniz");
                    int veri = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Girdiğiniz veri dogru : " + veri);
                    }catch(Exception e)
                    {
                        Console.WriteLine("Hata : " + "Hatalı Type Girdiniz Bida denemek için 1 basınız");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 1)
                        {
                            Main(args);
                        }
                    }
                    break;

            }
        }
    }

}