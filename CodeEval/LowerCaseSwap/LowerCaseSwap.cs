using System;
using System.Collections.Generic;
using System.Text;

//https://www.codeeval.com/open_challenges/20/
//To see the requirements for this project, please visit the link above.

namespace LowerCaseSwap
{
    class LowerCaseSwap
    {
        static void Main(string[] args)
        {
            //read the file that contains the sentences
            var f = "LowerCaseSwapFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            var finalList = new List<char>();
            foreach (var line in list)
            {
                //turn the line into a char array
                var inputLine = line.ToCharArray();
                //for each character in the character array, if it is lower or not a letter, keep it the same, if it is upper, make it lower
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
                //add each character from the list to a stringbuilder
                foreach (char letter in finalList)
                {
                    builder.Append(letter);
                }
                //print the edited sentence
                Console.WriteLine(builder.ToString());
                builder.Clear();
                finalList.Clear();
            }
            Console.ReadLine();
        }
    }
}


