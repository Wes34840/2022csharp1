namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string text = "Hello World";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }

        }
    }
}