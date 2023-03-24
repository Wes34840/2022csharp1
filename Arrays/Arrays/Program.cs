    namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Main = new Program();
            int[] integers = new int[] { 10, 20, 30, 40, 50, 60 };
            int Total = Main.GiveArray(integers);
            Console.WriteLine(Total);

        }
        private int GiveArray(int[] Argument)
        {
            int Total = 0;
            for (int i = 0; i < Argument.Length; i++)
            {
                Total += Argument[i];
            }
            return Total;
        }
    }
}