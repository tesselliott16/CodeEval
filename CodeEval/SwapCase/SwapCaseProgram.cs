using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapCase
{
    class SwapInputCase
    {
        static void Main(string[] args)
        {
            string f = "SwapCaseFile.txt";
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
                        var letterAdjusted = new char();
                        if (char.IsLower(letter))
                        {
                            letterAdjusted = char.ToUpper(letter);
                            finalList.Add(letterAdjusted);
                            continue;
                        }
                        if (char.IsUpper(letter))
                        {
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
