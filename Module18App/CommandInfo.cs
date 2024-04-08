using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18App;

internal class CommandInfo : Command
{
    private Receiver _receiver;
    public CommandInfo(Receiver receiver, string link) : base(link)
    {
        _receiver = receiver;
    }

    public override void Cancel()
    {
        throw new NotImplementedException();
    }

    public override async Task Run()
    {
        _receiver.GetInfoLog();
        var description = await _youtubeClient.Videos.GetAsync(Link);
        _receiver.GetDescriptionLog(description.Description);
    }
}
