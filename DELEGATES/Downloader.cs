namespace DELEGATES
{    
    public delegate void DownldrHandler(string msg);

    internal class Downloader : IDowloader
    {
        public int InternetSpeed { get; private set; }
        public int Buffer { get; set; }
        public DownldrHandler? handler;

        public void RegisterDelegate(DownldrHandler dlgt)
        {
            handler = dlgt;
        }

        public void Complete()
        {
            handler?.Invoke("Download has done");
        }

        public void Error()
        {
            handler?.Invoke("Internet speed is too slow");
        }

        /// <summary>
        /// Запускает цикл на каждой итерации которого скорость соединения рандомно генерируется от 0 до 100 и добавляется в буфер;
        /// Загрузка считается завершенной и вызывается метод Complete(), если буфер равен размеру файла;
        /// Метод Error() вызывается если интернет соеденение < 5. 
        /// </summary>
        /// <param name="_file"></param>
        public void Start(InternetFile _file)
        {
            Random random = new();

            Buffer = 0;

            while (true)
            {
                Console.Clear();

                if (Buffer >= _file.Size)
                {
                    Buffer = _file.Size;
                    Complete();
                    break;
                }
                else
                {
                    InternetSpeed = random.Next(0, 100);

                    if (InternetSpeed < 5)
                    {
                        Error();
                    }

                    Display.Show(_file, this);

                    Buffer += InternetSpeed;
                }

                Thread.Sleep(700);
            }
        }
    }
}
