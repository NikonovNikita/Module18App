using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18App;

internal class Logger : ILogger
{
    public void GetColoredConsoleLog(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void GetConsoleLog(string message)
    {
        Console.WriteLine(message);
    }
}
