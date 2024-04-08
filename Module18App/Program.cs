using Module18App;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

class Program
{
    static async Task Main(string[] args)
    {
        string videoPath = "https://www.youtube.com/watch?v=fxqE27gIZcc";
        Receiver receiver = new Receiver(new Logger());

        Invoker invoker = new();

        invoker.SetCommand(new CommandDownload(receiver, videoPath));
        await invoker.PressButtonRun();
        Console.WriteLine("\nПервая операция .Run(); выполнена");

        invoker.SetCommand(new CommandInfo(receiver, videoPath));
        await invoker.PressButtonRun();
        Console.WriteLine("\nВторая операция .Run(); выполнена");
    }
}