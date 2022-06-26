using Task_18_4_1.Commands;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task_18_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Отсутствует ссылка на  Youtube-видео!");
                return;
            }

            string url = args[0];

            // создадим отправителя
            var commandSender = new CommandSender();

            // создадим получателя
            var youtubeVideo = new YoutubeVideo(url);

            // создадим команду
            var commandYoutubeVideo = new CommandYoutubeVideo(youtubeVideo);

            // инициализация команды
            commandSender.SetCommand(commandYoutubeVideo);

            // выполнение
            commandSender.GetVideoInformation();
            commandSender.UploadVideo();
            
            Console.ReadLine();
        }
    }
}