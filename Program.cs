using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task_18_4_1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync("https://youtube.com/watch?v=u_yIGGhubZs");

            var title = video.Title; 
            var author = video.Author.ChannelTitle; 
            var duration = video.Duration; 

            Console.WriteLine($"Название: {title} Автор: {author} Продолжительность: {duration}");

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync("https://youtube.com/watch?v=u_yIGGhubZs");
            var streamInfo = streamManifest
                .GetVideoOnlyStreams()
                .Where(s => s.Container == Container.Mp4)
                .GetWithHighestVideoQuality();

            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");

            Console.ReadLine();
        }
    }
}