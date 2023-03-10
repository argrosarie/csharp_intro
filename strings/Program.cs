using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pricess Leia ID");
            string firstName = "Leia";
            string lastName = "Organa";
            int age = 27;
            var profession = "Warrior";

            string card = $"Princess {firstName}\n" +
            $"Name: {firstName} {lastName}\n" +
            $"Age: {age}\n" +
            $"Profession: {profession}\n";

            Console.WriteLine(card);
        }
    }
}
