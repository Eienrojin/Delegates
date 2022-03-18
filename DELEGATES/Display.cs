using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES
{
    public delegate void DisplayHandler(string msg);
    /// В классе Display должны отображаться: Размер файла, сколько загрузилось, процент загрузки. 
    internal class Display
    {
        public static DisplayHandler? displayHandler;

        public static void Show(InternetFile file, Downloader downdr)
        {
            double tempBuffer = downdr.Buffer;
            double _progress = tempBuffer / file.Size * 100;

            displayHandler.Invoke($"File size: {file.Size}" +
                             $"\nDownloaded: {downdr.Buffer}" +
                             $"\nDownload progress: {_progress}%");
        }

        public void RegisterDelegate(DisplayHandler dlgt)
        {
            displayHandler = dlgt;
        }
    }
}

