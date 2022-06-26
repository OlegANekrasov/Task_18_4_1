using System;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task_18_4_1
{
    /// <summary>
    /// Получатель команды
    /// </summary>
    class YoutubeVideo
    {
        YoutubeClient youtube;
        string url { get; }
        
        public YoutubeVideo(string url)
        {
            this.url = url;
            youtube = new YoutubeClient();
        }

        public async void GetVideoInformation()
        {
            var video = await youtube.Videos.GetAsync(url);

            var title = video.Title;
            var author = video.Author.ChannelTitle;
            var duration = video.Duration;
            var description = video.Description;

            Console.WriteLine($"Название: {title} Автор: {author} Продолжительность: {duration} \nDescription: {description}");
        }

        public async void UploadVideo()
        {
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);
            var streamInfo = streamManifest
                .GetVideoOnlyStreams()
                .Where(s => s.Container == Container.Mp4)
                .GetWithHighestVideoQuality();

            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            Console.WriteLine("\nСкачивается видео...");
        }
    }
}
