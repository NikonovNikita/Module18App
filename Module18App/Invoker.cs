using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18App;

internal class Invoker
{
    Command Command { get; set; }

    public void SetCommand(Command command)
    {
        Command = command;
    }

    public async Task PressButtonRun()
    {
        if (Command != null)
        {
            await Command.Run();
        }
    }

    public void PressButtonCancel()
    {
        if (Command != null)
        {
            Command.Cancel();
        }
    }
}
