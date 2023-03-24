namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Main = new Program();
            Main.WriteInConsole(40, "Hello World");

        }
        private void WriteInConsole(int a, string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}