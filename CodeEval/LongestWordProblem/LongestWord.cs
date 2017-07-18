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
                string f = @"C:\_Projects\CodeEval\CodeEval\LongestWordProblem\LongestWordFile.txt";
                var list = new List<string>();
                var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
                using (var reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string longestLength = string.Empty;
                        string[] result = line.Split(' ');
                        for (int i = 0; i < result.Length; i++)
                        {
                            if (i == 0)
                            {
                                longestLength = result[i];
                            }
                            if (i > 0)
                            {
                                longestLength = StringLength(longestLength, result[i]);
                            }
                        }
                        Console.WriteLine(longestLength);


                    }
                    Console.ReadLine();
                }
            }

            static string StringLength(string x, string y)
            {
                int xLength = x.Length;
                int yLength = y.Length;
                if (xLength == yLength)
                {
                    return x;
                }
                else
                {
                    return x.Length > y.Length ? x : y;
                }
                
            }
        }
    }
}
