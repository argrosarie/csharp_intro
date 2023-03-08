using System;

namespace logicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value1 = true;
            bool value2 = true;
            bool value3 = true;
            bool result = value1 && value2;

            Console.WriteLine(result);

            bool resultOr = value1 || value2 || value3;
            Console.WriteLine(resultOr);

        }
    }
}
