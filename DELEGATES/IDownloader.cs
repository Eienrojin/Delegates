using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES
{
    /// <summary>
    /// Класс загрузчик. 
    /// Должен содержать в поле: скорость интернет соеденения, буфер
    /// В классе Display должны отображаться: Размер файла, сколько загрузилось, процент загрузки. 
    /// По завершении загрузки должно выводится "Загрузка завершена". При скорости < 5, что слабое интернет соединение
    /// </summary>
    internal interface IDowloader
    {

        /// <summary>
        /// Запускает цикл на каждой итерации которого скорость соединения рандомно генерируется от 0 до 100 и добавляется в буфер;
        /// Загрузка считается завершенной и вызывается метод Complete(), если буфер равен размеру файла;
        /// Метод Error() вызывается если интернет соеденение < 5. 
        /// </summary>
        /// <param name="_file"></param>
        void Start(InternetFile _file);


        void Complete();


        void Error();
    }
}
