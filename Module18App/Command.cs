using YoutubeExplode;

namespace Module18App;

internal abstract class Command
{
    protected YoutubeClient _youtubeClient = new();
    protected string Link { get; set; }

    public Command(string link)
    {
        Link = link;
    }

    public abstract Task Run();
    public abstract void Cancel();
}
