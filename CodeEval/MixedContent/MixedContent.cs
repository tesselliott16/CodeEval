using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace MixedContent
{
    class MixedContent
    {
        static void Main(string[] args)
        {
            string f = "MixedContentFile.txt";
            var list = new List<string>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] mixedContentUnsorted = line.Split(',');
                    List <string> numbers = new List<string>();
                    List<string> words = new List<string>();
                    for (int i = 0; i < mixedContentUnsorted.Length; i++)
                    {
                        if (Regex.IsMatch(mixedContentUnsorted[i], @"^\d+$"))
                        {
                            numbers.Add(mixedContentUnsorted[i]);
                        }
                        else
                        {
                            words.Add(mixedContentUnsorted[i]);
                        }
                    }
                    string printWords = string.Join(",", words);
                    string printNumbers = string.Join(",", numbers);
                    if (words.Count == 0)
                    {
                        Console.WriteLine(printNumbers);
                        break;
                    }
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine(printWords);
                        break;
                    }
                    string printLine = string.Join("|", printWords, printNumbers);
                    Console.WriteLine(printLine);
                }
            }
            Console.ReadLine();
        }
    }
}
