using System;
using System.Collections.Generic;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Anna", "John", "Alice", "Bo" };

            // Visa original listan
            Console.WriteLine("Original lista:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Sortera namnen alfabetiskt
            names.Sort();
            Console.WriteLine("\nSorterad lista:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Sök efter namn
            Console.WriteLine("\nAnge namn att söka efter: ");
            string searchName = Console.ReadLine();

            // Implementera felhantering för sökningen
            if (string.IsNullOrWhiteSpace(searchName))
            {
                Console.WriteLine("Namnet kan inte vara tomt.");
            }
            else if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} finns i listan.");
            }
            else
            {
                Console.WriteLine($"{searchName} finns inte i listan.");
            }

            Console.ReadKey();
        }
    }
}
