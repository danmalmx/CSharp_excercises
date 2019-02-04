using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Excercises (Basic) from https://www.w3resource.com/csharp-exercises/basic/index.php

            //Excercise 11
            //Console.Write("Enter your age: ");
            //var age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You look older than {0}", age);
            //Console.ReadKey();       

            ////Excercise 12
            //Console.Write("Enter a number: ");
            //var number = Console.ReadLine();
            //Console.WriteLine("{0} {0} {0} {0}", number);
            //Console.WriteLine("{0}{0}{0}{0}", number);
            //Console.WriteLine("{0} {0} {0} {0}", number);
            //Console.WriteLine("{0}{0}{0}{0}", number);

            //Console.ReadKey();

            ////Excercise 13
            //Console.Write("Enter a number: ");
            //var number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0}{0}{0}", number);
            //Console.WriteLine("{0} {0}", number);
            //Console.WriteLine("{0} {0}", number);
            //Console.WriteLine("{0} {0}", number);
            //Console.WriteLine("{0}{0}{0}", number);

            //Console.ReadKey();

            ////Excercises 14
            //Console.Write("Enter degrees in Celcius: ");
            //var number = Convert.ToInt32(Console.ReadLine());
            //float kelvin = number +273.15f;
            //float farenheit = number * 1.8f + 32f;

            //Console.WriteLine("Kelvin = {0}", kelvin);
            //Console.WriteLine("Farenheit = {0}", farenheit);
            //Console.ReadKey();

            //Excercises 15
            //Console.Write("Text: ");
            //var text = Console.ReadLine();

            //Console.WriteLine("{0}", text.Remove(1, 1));
            //Console.WriteLine("{0}", text.Remove(text.Length - 1, 1));
            //Console.WriteLine("{0}", text.Remove(0, 1));

            //Console.ReadKey();

            //Excercises 16

            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));

            Console.ReadKey();
        }

        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}