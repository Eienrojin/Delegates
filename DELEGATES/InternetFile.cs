using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES
{
    /// <summary>
    /// Должен содержать в поле: Название, размер файла
    /// </summary>
    internal class InternetFile
    {
        public InternetFile(string name, int size)
        {
            Name=name;
            Size=size;
        }

        public string Name { get; set; }
        public int Size { get; set; }
    }
}
