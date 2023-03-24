using Classes;
using System.Runtime.InteropServices;

namespace ClassesConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Rectangle Rectangle1 = new Rectangle(100, 200, 50, 50);
            Console.WriteLine(Rectangle1.x);
        }
    }
}