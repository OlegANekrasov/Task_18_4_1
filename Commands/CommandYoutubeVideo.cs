using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18_4_1.Commands
{
    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class CommandYoutubeVideo : Command
    {
        YoutubeVideo youtubeVideo;

        public CommandYoutubeVideo(YoutubeVideo youtubeVideo)
        {
            this.youtubeVideo = youtubeVideo;
        }

        /// <summary>
        /// Выводит в консоль информацию: название видео и описание
        /// </summary>
        public override void GetVideoInformation()
        {
            youtubeVideo.GetVideoInformation();
        }

        /// <summary>
        /// Скачивает видео
        /// </summary>
        public override void UploadVideo()
        {
            youtubeVideo.UploadVideo();
        }
    }
}
