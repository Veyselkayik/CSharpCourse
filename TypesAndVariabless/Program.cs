using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariabless { 

    internal class Program
    {
        static void Main(string[] args)
        {
            
            decimal number6 = 10.4m;
            double number5 = 10.4;
            char character = 'A';
            Boolean condition = true;
            byte number4 = 255;
            short number3 = -32768;
            int number1 = 2147483647;
            long number2 = -9223372036854775808;
            var number7 = 10;
            number7 = 'A';
        
            //Console.WriteLine("Hello Ezgi <3");
            Console.WriteLine("Number1 is {0} ",number1);
            Console.WriteLine("Number2 is {0} ", number2);
            Console.WriteLine("Number3 is {0} ", number3);
            Console.WriteLine("Number4 is {0} ", number4);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine("Number5 is {0} ", number5);
            Console.WriteLine("Number6 is {0} ", number6);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Number7 is {0} ", number7);
            Console.ReadLine();
        } 
       
    }

enum Days
{
    Monday=10, Tuesday,Wednesday,Thursday,Friday,Sturday,Sunday
}
}
