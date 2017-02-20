using System;

namespace ConsoleApplication3
{
    internal class ConsoleReaderProvider
    {
        // TODO: make ConsoleReaderProvider implement IReader
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
