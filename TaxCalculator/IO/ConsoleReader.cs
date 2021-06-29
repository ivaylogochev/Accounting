namespace TaxCalculator.IO
{
    using System;
    using TaxCalculator.IO.Contracts;
    class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
