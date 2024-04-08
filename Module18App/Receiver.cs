namespace Module18App;

internal class Receiver
{
    ILogger logger;
    public Receiver(ILogger logger)
    {
        this.logger = logger;
    }
    public void GetDownloadLog()
    {
        logger.GetColoredConsoleLog("Началась загрузка. . .\n");
    }

    public void GetInfoLog()
    {
        logger.GetColoredConsoleLog("Получение информации о видео. . .\n");
    }

    public void GetDescriptionLog(string description)
    {
        logger.GetConsoleLog(description);
    }
}
