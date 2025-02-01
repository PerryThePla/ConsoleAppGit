namespace ConsoleAppGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dadi dadi = new Dadi();
            Console.WriteLine(dadi.Lanciadado());
            Console.WriteLine(dadi.Lanciadado());
            Console.ReadKey();
        }
    }
}
