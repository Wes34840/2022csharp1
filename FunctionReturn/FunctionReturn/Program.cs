namespace FunctionReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Main = new Program();
            int Number = Main.RandomInt();
            Console.WriteLine(Number);
        }
        internal int RandomInt()
        {
            Random rand = new Random();
            
            return rand.Next(1, 100);
        }
    }
}