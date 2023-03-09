using System;

namespace relationalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var(value1, value2, value3, value4) = (10, 1, 2, 2);
            // ==
            // !=
            // <
            // >
            // <=
            // >=
            bool result1 = value1 == value2;
            Console.WriteLine(result1);
            bool result2 = value3 != value4;
            Console.WriteLine(result2);
            bool result3 = value1 > value2;
            Console.WriteLine(result3);
            bool result4 = value3 >= value4;
            Console.WriteLine(result4);
        }
    }
}
