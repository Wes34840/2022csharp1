using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); // Write string in console
            var random = new Random(); // New number randomiser
            var value = random.Next();  // New random number
            Console.WriteLine(value); // Write random number in console

            Console.Write("Enter string:"); // Ask for input
            string input = Console.ReadLine(); // Read input
            Console.WriteLine("Your input was " + input); // Write input
            Console.Write("Press enter to close this program. . .");
            Console.ReadLine();
        }
    }
}