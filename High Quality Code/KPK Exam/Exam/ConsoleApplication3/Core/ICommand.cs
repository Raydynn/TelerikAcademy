using System.Collections.Generic;

namespace ConsoleApplication3
{
    internal interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
