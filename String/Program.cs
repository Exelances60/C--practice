using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            Console.WriteLine(city[0]);

            string city2 = "New York";
            Console.WriteLine(String.Format("Welcome to {0} {1}", city2, city)); // result = city2 + city diyip atama yapabilirdim ama bellekte yer kaplamasın diye bu şekilde yazdım.

            string sentece= "My name is Mehmet";
            var result = sentece.Clone(); // Clone() metodu ile sentece değişkeninin kopyasını oluşturduk.
            sentece = "My name is Mehmet Ali"; // sentece değişkeninin değerini değiştirdik.
            Console.WriteLine(result); // result değişkeninin değeri değişmedi. Çünkü sentece değişkeninin kopyasını oluşturmuştuk.

            bool result2= sentece.EndsWith("Ali"); // sentece değişkeninin sonu "Ali" ile bitiyor mu?
            bool result3 = sentece.StartsWith("My name"); // sentece değişkeninin başı "My name" ile başlıyor mu?
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            var result4= sentece.IndexOf("name"); // sentece değişkeninin içinde "name" kelimesi var mı? Varsa kaçıncı indexte?
            Console.WriteLine(result4);
            var result5 = sentece.LastIndexOf(" "); // sentece değişkeninin içindeki son boşluğun indexini verir.
            Console.WriteLine(result5);
            
            var result6= sentece.Insert(0,"Hello , "); // sentece değişkeninin 0. indexine "Hello, " kelimesini ekler.
            Console.WriteLine(result6);

            var result7=sentece.Substring(3); // sentece değişkeninin 3. indexinden sonrasını alır.
            Console.WriteLine(result7);
            var result8 = sentece.Substring(3,4); // sentece değişkeninin 3. indexinden başlayarak 4 karakter alır.
            Console.WriteLine(result8);

            var result9= sentece.Replace(" ", "-"); // sentece değişkeninin içindeki boşlukları "-" ile değiştirir.
            Console.WriteLine(result9);

            var result10 = sentece.Remove(2); // sentece değişkeninin 2. indexinden sonrasını siler.
            Console.WriteLine(result10);

            var result11 = sentece.Remove(2,5); // sentece değişkeninin 2. indexinden başlayarak 5 karakter siler.
            Console.WriteLine(result11);

            Console.ReadKey();
        }
    }
}
