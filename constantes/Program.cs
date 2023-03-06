using System;

namespace constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            var ratio = 0d;
            var result = 0d;

            Console.WriteLine("Welcome, let's calculate some circles!");

            //PI * ratio * ratio
            Console.WriteLine("Please enter ratio's value");
            ratio = Convert.ToDouble(Console.ReadLine());

            result = Math.PI * ratio * ratio;

            Console.WriteLine("The result is : " + result);
        }
    }
}
