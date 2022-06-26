using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18_4_1.Commands
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class CommandSender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        /// <summary>
        /// Получить информацию
        /// </summary>
        public void GetVideoInformation()
        {
            _command.GetVideoInformation();
        }

        /// <summary>
        /// Скачать видео
        /// </summary>
        public void UploadVideo()
        {
            _command.UploadVideo();
        }
    }
}
