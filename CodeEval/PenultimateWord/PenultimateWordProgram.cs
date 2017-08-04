using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenultimateWord
{
    class PenultimateWordProgram
    {
        static void Main(string[] args)
        {
            string f = "PenultimateWordFile.txt";
            var list = new List<string>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    Console.WriteLine(words[words.Length - 2]);
                }
            }
            Console.ReadLine();
        }
    }
}
