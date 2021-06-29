namespace TaxCalculator
{
    using Core;
    using IO;
    using IO.Contracts;
    using Models.Contracts;
    using TaxCalculator.Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IWriter consoleWriter = new ConsoleWriter();
            IReader consoleReader = new ConsoleReader();

            Engine engine = new Engine(consoleWriter, consoleReader);

            engine.Run();
        }
    }
}
