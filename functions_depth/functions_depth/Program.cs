namespace functions_depth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program Main = new Program();
            Main.StringFunction("Hello World");
        }
        void StringFunction(string a)
        {
            StringIntFunction(a, 40);
        }
        void StringIntFunction(string a, int b)
        {
            StringIntBoolFunction(a, b, true);
        }
        void StringIntBoolFunction(string a, int b, bool c)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}