using System;

namespace ClassOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //maak hier een variable aan met type ShopGreeter
            ShopGreeter Shopgreeter = new ShopGreeter();
            //roep de function greetcustomer aan
            Shopgreeter.GreetCustomer();
        }
    }
}