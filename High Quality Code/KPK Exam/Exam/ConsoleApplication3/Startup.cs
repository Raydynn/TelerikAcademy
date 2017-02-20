using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace ConsoleApplication3
{
    class Startup
    {
        static void Main()
        {
            // TODO: abstract at leest 2 more provider like this one
            var reader = new ConsoleReaderProvider();

            var service = new BusinessLogicService();
            service.Execute(reader);
        }
    }
}
