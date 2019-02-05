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

            ////Excercise 1
            //Console.WriteLine("Hello:");
            //Console.WriteLine("Daniel!");

            ////Excercise 2
            //Console.WriteLine(1+2);

            ////Excercise 3
            //Console.WriteLine(10/5);

            ////Excercise 4
            //Console.WriteLine(-1 + 4 * 6);
            //Console.WriteLine((35 + 5) % 7);
            //Console.WriteLine(14 +- 4 * 6 /11 );
            //Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            ////Excercise 5
            //Console.WriteLine("Number 1:");
            //var n1 = Console.ReadLine();
            //int first = Convert.ToInt32(n1);

            //Console.WriteLine("Number 2:");
            //var n2 = Console.ReadLine();
            //int second = Convert.ToInt32(n2);

            //var temp = n1;
            //n1 = n2;
            //n2 = temp;

            //Console.WriteLine(); 
            //Console.WriteLine("Swap magic");
            //Console.WriteLine();

            //Console.WriteLine("First number: {0}. Second number: {1}", n1, n2);

            ////Excercise 6
            //Console.WriteLine("Number 1:");
            //var n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 2:");
            //var n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 3:");
            //var n3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Output of {0} * {1} * {2} = {3}", n1, n2, n3, n1 * n2 * n3);

            ////Excercise 7
            //Console.WriteLine("Number 1:");
            //var n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 2:");
            //var n2 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
            //Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
            //Console.WriteLine("{0} * {1} = {2}", n1, n2, n1 * n2);
            //Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
            //Console.WriteLine("{0} % {1} = {2}", n1, n2, n1 % n2);

            ////Excercise 8
            //Console.WriteLine("Number 1:");
            //var n1 = Convert.ToInt32(Console.ReadLine());

            //for (var i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", n1, i, n1 * i);
            //}

            ////Excercise 9
            //Console.WriteLine("Number 1:");
            //var n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 2:");
            //var n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 3:");
            //var n3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 4:");
            //var n4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The average of {0}, {1}, {2}, {3} is {4}", n1, n2, n3, n4, (n1 + n2 + n3 + n4)/4);

            //Excercise 10
            //Console.WriteLine("Number 1:");
            //var x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 2:");
            //var y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number 3:");
            //var z = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(@"Result of {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}", -x, -y, -z, (x + y) * z, (x * y) + (y * z));

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

            ////Excercise 14
            //Console.Write("Enter degrees in Celcius: ");
            //var number = Convert.ToInt32(Console.ReadLine());
            //float kelvin = number +273.15f;
            //float farenheit = number * 1.8f + 32f;

            //Console.WriteLine("Kelvin = {0}", kelvin);
            //Console.WriteLine("Farenheit = {0}", farenheit);
            //Console.ReadKey();

            //Excercise 15
            //Console.Write("Text: ");
            //var text = Console.ReadLine();

            //Console.WriteLine("{0}", text.Remove(1, 1));
            //Console.WriteLine("{0}", text.Remove(text.Length - 1, 1));
            //Console.WriteLine("{0}", text.Remove(0, 1));

            //Console.ReadKey();

            //Excercise 16

            //    Console.WriteLine(first_last("w3resource"));
            //    Console.WriteLine(first_last("Python"));
            //    Console.WriteLine(first_last("x"));

            //    Console.ReadKey();
            //}

            //public static string first_last(string ustr)
            //{
            //    return ustr.Length > 1
            //        ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
            //}

            ////Excercises 17
            //Console.Write("Text: ");
            //string text = Console.ReadLine();
            //string extract = text.Substring(0, 1);
            //Console.WriteLine("{0}{1}{0}", extract, text, extract);
            //Console.ReadKey();

            //Excercise 18
            //Console.Write("Enter first integer: ");
            //var number_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second integer: ");
            //var number_2 = Convert.ToInt32(Console.ReadLine());
            //if (number_1 > 0 || number_2 > 0)
            //{
            //    Console.WriteLine((number_1 < 0 && number_2 > 0) || (number_1 > 0 && number_2 < 0));

            //    Console.ReadKey();
            //}

            //Excercise 19
            //Console.Write("Enter first integer: ");
            //var number_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second integer: ");
            //var number_2 = Convert.ToInt32(Console.ReadLine());
            //if (number_1  == number_2)
            //{
            //    Console.WriteLine((number_1 + number_2) * 3);
            //}
            //else
            //{
            //    Console.WriteLine(number_1 + number_2);
            //}
            //Console.ReadKey();

            //Excercise 20
            //Console.Write("Enter first integer: ");
            //var number_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second integer: ");
            //var number_2 = Convert.ToInt32(Console.ReadLine());
            //if (number_1 > number_2)
            //{
            //    Console.WriteLine((number_1 - number_2)*2);
            //}
            //else
            //{
            //    Console.WriteLine(number_2 - number_1);
            //}
            //Console.ReadKey();


            //Excercise 21
            //Console.Write("Enter first integer: ");
            //var number_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second integer: ");
            //var number_2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine((number_1 + number_2 == 20) || (number_1 == 20 || number_2 == 20));
            //Console.ReadKey();


            //Excercise 22
            Console.Write("Enter an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(x - 100) <=10 || Math.Abs(x - 200) <= 10)
            {
                Console.WriteLine(true);
            } else
            {
            Console.WriteLine(false);
            }

            Console.ReadKey();
        }
    }
}