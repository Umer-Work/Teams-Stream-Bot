using Microsoft.Skype.Bots.Media;

namespace TeamsBot.Bot
{
    public class MediaStreamEventArgs
    {
        public List<AudioMediaBuffer>? AudioMediaBuffers { get; set; } = new List<AudioMediaBuffer>();
    }
}
