using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Veysel Kayık";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Veysel Kayık";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name");//cümle içinde arar


          
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");//sondan arar
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);//3.karakterden yazmaya başlar 4 karakter yazar
            var result10 = sentence.ToLower(); //küçük harf 
            var result11 = sentence.ToUpper();//büyük harf
            var result12 = sentence.Replace(" ", "-"); // boşluk yerine çizgiyle değiştiriyor
            var result13 = sentence.Remove(2,4);//2den itibaren 4 tane atar
            Console.WriteLine(result13);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            ////string result = city + city2;
            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
