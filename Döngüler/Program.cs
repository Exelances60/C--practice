using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Int veri Giriniz \n 2-Float Veri geriniz \n 3-Double veri giriniz \n 4-Bool veri giriniz \n 5-string veri giriniz \n 6-object veri giriniz");
            int secim = Convert.ToInt32(Console.ReadLine());
            TekrarSayıAlma:
            Console.WriteLine("Lütfen bir veri giriniz");
            var inputValue = Console.ReadLine();
            switch (secim)
            {
                case 1:
                    try
                    {
                        int veri =int.Parse(inputValue);
                        Console.WriteLine("Girdiğiniz veri dogru : " + veri + " 1 basarak tekrardan rakam girebilrisinz");
                        int returnBack = Convert.ToInt32(Console.ReadLine());
                        if(returnBack == 1) goto TekrarSayıAlma;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hata : " + "Hatalı Type Girdiniz Bida denemek için 2 basınız");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 2)
                        {
                            Main(args);
                        }
                    }
                    break;
                case 2:
                    try
                    {
                        float veri = float.Parse(inputValue);
                        Console.WriteLine("Girdiğiniz veri dogru : " + veri + " 1 basarak tekrardan rakam girebilrisinz");
                        Console.WriteLine(veri.GetType());
                        int returnBack = Convert.ToInt32(Console.ReadLine());
                        if (returnBack == 1) goto TekrarSayıAlma;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hata : " + "Hatalı Type Girdiniz Bida denemek için 1 basınız");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 1)
                        {
                            Main(args);
                        }
                    }
                    break;
                case 3:
                    try
                    {
                        double veri = double.Parse(inputValue);
                        Console.WriteLine("Girdiğiniz veri dogru : " + veri + " 1 basarak tekrardan rakam girebilrisinz");
                        Console.WriteLine(veri.GetType());
                        int returnBack = Convert.ToInt32(Console.ReadLine());
                        if (returnBack == 1) goto TekrarSayıAlma;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hata : " + "Hatalı Type Girdiniz Bida denemek için 1 basınız");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 1)
                        {
                            Main(args);
                        }
                    }
                    break;
                case 4:
                    try
                    {
                        bool veri = bool.Parse(inputValue);
                        Console.WriteLine("Girdiğiniz veri dogru : " + veri + " 1 basarak tekrardan rakam girebilrisinz");
                        int returnBack = Convert.ToInt32(Console.ReadLine());
                        if (returnBack == 1) goto TekrarSayıAlma;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hata : " + "Hatalı Type Girdiniz Bida denemek için 2 basınız");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 2)
                        {
                            Main(args);
                        }
                    }
                    break;
                case 5:
                    try
                    {
                        string veri = inputValue;
                        Console.WriteLine("Girdiğiniz veri dogru : " + veri + " 1 basarak tekrardan rakam girebilrisinz");
                        int returnBack = Convert.ToInt32(Console.ReadLine());
                        if (returnBack == 1) goto TekrarSayıAlma;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hata : " + "Hatalı Type Girdiniz Bida denemek için 2 basınız");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 2)
                        {
                            Main(args);
                        }
                    }
                    break;
                case 6:
                    try
                    {
                        object veri = Convert.ChangeType(inputValue, typeof(object));
                        Console.WriteLine("Girdiğiniz veri dogru : " + veri + " 1 basarak tekrardan rakam girebilrisinz");
                        int returnBack = Convert.ToInt32(Console.ReadLine());
                        if (returnBack == 1) goto TekrarSayıAlma;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Hata : " + "Hatalı Type Girdiniz Bida denemek için 2 basınız");
                        int secim2 = Convert.ToInt32(Console.ReadLine());
                        if (secim2 == 2)
                        {
                            Main(args);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız");
                    break;

            }


            Console.ReadLine();
        }
    }
}
