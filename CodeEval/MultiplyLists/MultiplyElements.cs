using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MultiplyElementsCodeEval
{
    class MultiplyElements
    {
        static void Main(string[] args)
        {
            string f = "MultiplyListsFile.txt";
            var list = new List<string>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] result = line.Split('|');
                    string[] right = result[0].Split(' ');
                    int[] rightInt = Array.ConvertAll(right, x => int.Parse(x));
                    string[] left = result[1].Split(' ');
                    int[] leftInt = Array.ConvertAll(left, x => int.Parse(x));
                    var final = new List<int>();
                    for (int c=0; c<right.Length; c++)
                    {
                        int result2 = Multiply(rightInt[c], leftInt[c]);
                        final.Add(result2);
                    }
                    Console.WriteLine(string.Join(" ", final.Select(x => x.ToString()).ToArray()));
                }
                Console.ReadLine();
            }
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
