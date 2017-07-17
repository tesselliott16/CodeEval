using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordProblem
{
    class LongestWord
    {
        class MultiplyElements
        {
            static void Main(string[] args)
            {
                string f = "LongestWordFile.txt";
                var list = new List<string>();
                var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
                using (var reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] result = line.Split(' ');
                        var longestLength = new List<string>();
                        for (int i = 0; i < result.Length; i++)
                        {
                            longestLength.Add(StringLength(result[i], result[i+1])); 
                        }

                        Console.WriteLine(longestLength);
                    }
                    Console.ReadLine();
                }
            }

            static string StringLength(string x, string y)
            {
                return x.Length > y.Length ? x : y;
            }
        }
    }
}
