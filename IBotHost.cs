namespace TeamsBot
{
    public interface IBotHost
    {
        Task StartAsync();

        Task StopAsync();
    }
}