using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Module18App;

internal class CommandDownload : Command
{
    private Receiver _receiver;
    public CommandDownload(Receiver receiver, string link) : base(link)
    {
        _receiver = receiver;
    }
    public override void Cancel()
    {
        throw new NotImplementedException();
    }

    public override async Task Run()
    {
        _receiver.GetDownloadLog();
        var streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(Link);
        var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
        await _youtubeClient.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
    }
}
