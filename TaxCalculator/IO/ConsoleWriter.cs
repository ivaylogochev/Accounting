namespace TaxCalculator.IO
{
    using System;
    using TaxCalculator.IO.Contracts;
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
