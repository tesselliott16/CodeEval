using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringGenerator;

namespace FileSize
{
    class FileSizeFinder
    {
        static void Main(string[] args)
        {
            GenerateRandomString.CreateFile(1000, GenerateRandomString.GenerateType.Numeric, 5);
            string f = GenerateRandomString.FileName.GeneratedFilePath;
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                FileInfo info = new FileInfo(f);
                long fileLength = f.Length;
                Console.WriteLine(fileLength);
            }
            Console.ReadLine();
        }
    }
}
