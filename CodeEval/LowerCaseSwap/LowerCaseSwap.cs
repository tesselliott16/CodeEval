using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerCaseSwap
{
    class LowerCaseSwap
    {
        static void Main(string[] args)
        {
            string f = "LowerCaseSwapFile.txt";
            List<char> finalList = new List<char>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    char[] inputLine = line.ToCharArray();

                    foreach (char letter in inputLine)
                    {

                        if (char.IsLower(letter))
                        {
                            finalList.Add(letter);
                            continue;
                        }
                        if (char.IsUpper(letter))
                        {
                            var letterAdjusted = new char();
                            letterAdjusted = char.ToLower(letter);
                            finalList.Add(letterAdjusted);
                            continue;
                        }
                        else
                        {
                            finalList.Add(letter);
                            continue;
                        }
                    }
                    StringBuilder builder = new StringBuilder();
                    foreach (char letter in finalList)
                    {
                        builder.Append(letter);
                    }
                    Console.WriteLine(builder.ToString());
                    builder.Clear();
                    finalList.Clear();
                }
            }
            Console.ReadLine();
        }
    }
}


