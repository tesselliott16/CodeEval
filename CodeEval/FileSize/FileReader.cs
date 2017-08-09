using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileSize
{
    public class FileReader
    {
        public static List<string> FileReaderInit(string pathName)
        {
            var list = new List<string>();
            list.Clear();
            var fileStream = new FileStream(pathName, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); 
                    Console.WriteLine(list);
                }
            }
            return list;
        }
    }
}
