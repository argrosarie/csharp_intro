using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA;
            int sideB;
            int result;
            Console.WriteLine("Calcula area de rectangulo");
            Console.WriteLine("Ingrese valor de lado A");
            sideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese valor de lado B");
            sideB = Convert.ToInt32(Console.ReadLine());

            result = sideA * sideB;
            Console.WriteLine("El resultado es: " + result);
        }
    }
}
