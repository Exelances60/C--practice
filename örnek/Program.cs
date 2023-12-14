using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayaç =0;
            Console.WriteLine("1-Int veri Giriniz \n 2-Float Veri geriniz \n 3-Double veri giriniz \n 4-Bool veri giriniz \n 5-string veri giriniz \n 6-object veri giriniz");
            int secim=Convert.ToInt32(Console.ReadLine());
            TekrarSayıAlma:
            Console.WriteLine("Bir Sayı Giriniz");
            var inputValue = Console.ReadLine();
           
            if (sayaç == 5)
            {
                 Console.WriteLine("5 Defa Hatalı Giriş Yaptınız");
                
            }else { 
            switch (secim)
            {
                case 1:
                    {
                        try
                        {
                            int veri=Convert.ToInt32(inputValue);
                                Console.WriteLine(veri.GetType());
                            Console.WriteLine("Girdiğiniz veri dogru : " + veri + " 1 basarak tekrardan rakam girebilrisinz");
                            int returnBack=Convert.ToInt32(Console.ReadLine());
                            if(returnBack==1) goto TekrarSayıAlma;
                        }catch(Exception error)
                        {
                            Console.WriteLine("Girdigin Deger İnt bir deger degil : " + error.Message +"2 Baksarak tekrar rakam giriniz");
                            int returnBack = Convert.ToInt32(Console.ReadLine());
                                sayaç++;
                                if (returnBack == 2) goto TekrarSayıAlma;



                        }
                    }
                    break;
                    case 2:
                        {
                            try
                            {
                                float veri = float.Parse(inputValue);
                                Console.WriteLine("Girdiğiniz veri dogru : " + veri + " 1 basarak tekrardan rakam girebilrisinz");
                                int returnBack = Convert.ToInt32(Console.ReadLine());
                                if (returnBack == 1) goto TekrarSayıAlma;
                            }catch(Exception error) { 
                            }
                        }
                        break;
                    default :
                    {
                        Console.WriteLine("Geçersiz Seçim Degeri Girdiniz");
                    }
                    break;
            }

            }
            Console.ReadLine();
        }
    }
}
