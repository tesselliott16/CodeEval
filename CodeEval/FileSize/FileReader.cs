using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSize
{
    public class FileReader
    {
        public static System.IDisposable FileReaderInit(string pathName)
        {
            string f = pathName;
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(fileStream, Encoding.UTF8);
            return reader;
        }
    }
}
