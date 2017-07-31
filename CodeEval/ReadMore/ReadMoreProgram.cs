using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMore
{
    class ReadMoreProgram
    {
        static void Main(string[] args)
        {
            string f = "ReadMoreFile.txt";
            var list = new List<string>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var foundIndexes = new List<int>();
                    char[] lineArray = line.ToCharArray();
                    if (line.Length > 55)
                    {
                        for (int i = 0; i < lineArray.Length; i++)
                        {
                            if (lineArray[i] == ' ')
                            {
                                foundIndexes.Add(i);
                            }
                        }
                        var trimIndexes = new List<int>();
                        for (int i = 0; i < foundIndexes.Count; i++)
                        {
                            if (foundIndexes[i] < 40)
                            {
                                trimIndexes.Add(foundIndexes[i]);
                            }
                        }
                        int length = trimIndexes.Count;
                        string result = string.Concat(line.Take(40));
                        int cutPoint = trimIndexes[length - 1];
                        string finalTrim = string.Concat(result.Take(cutPoint));
                        Console.WriteLine(finalTrim + ". . . <Read More>");
                        continue;
                    }
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}
