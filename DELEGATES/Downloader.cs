using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES
{
    internal class Downloader : IDowloader
    {
        public int InternetSpeed { get; private set; }
        public int Buffer { get; set; }

        public void Complete()
        {
            throw new NotImplementedException();
        }

        public void Error()
        {
            throw new NotImplementedException();
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

            while (true)
            {
                this.InternetSpeed = 
            }
            
        }
    }
}
