using ClassOefening;

namespace ShopGreeterOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ShopGreeter greeter = new ShopGreeter();

            greeter.GreetCustomer();
        }
    }
}