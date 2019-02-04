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
            //Excercises 11
            //Console.Write("Enter your age: ");
            //var age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You look older than {0}", age);
            //Console.ReadKey();       
            
            ////Excercises 12
            //Console.Write("Enter a number: ");
            //var number = Console.ReadLine();
            //Console.WriteLine("{0} {0} {0} {0}", number);
            //Console.WriteLine("{0}{0}{0}{0}", number);
            //Console.WriteLine("{0} {0} {0} {0}", number);
            //Console.WriteLine("{0}{0}{0}{0}", number);

            //Console.ReadKey();

            ////Excercises 13
            //Console.Write("Enter degrees in Celcius: ");
            //var number = Convert.ToInt32(Console.ReadLine());
            //float kelvin = number +273.15f;
            //float farenheit = number * 1.8f + 32f;

            //Console.WriteLine("Kelvin = {0}", kelvin);
            //Console.WriteLine("Farenheit = {0}", farenheit);
            //Console.ReadKey();

            //Excercises 14
            Console.Write("Text: ");
            var text = Console.ReadLine();
            
            Console.WriteLine("{0}", text.Remove(1));
            Console.WriteLine("{0}", text.Remove(-1));
            Console.WriteLine("{0}", text.Remove(0));

            Console.ReadKey();
        }
    }
}
