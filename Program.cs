namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static void ProcessIfNeeded(string[] args)
        {
            if (args.Any())
            {
                Console.WriteLine("Processing...");
                foreach (var arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
            else
            {
                Console.WriteLine("No arguments provided.");
            }
        }        
    }
}
