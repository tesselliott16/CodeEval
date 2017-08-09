using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//https://www.codeeval.com/open_challenges/115/
//To find the requirements for this file, visit the link above

namespace MixedContent
{
    internal class MixedContent
    {
        static void Main(string[] args)
        {
            //read the file, containing a list of numbers and words seperated by commas
            var f = "MixedContentFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //split the line of the file on the comma
                var mixedContentUnsorted = line.Split(',');
                var numbers = new List<string>();
                var words = new List<string>();
                //for each item in the list, check and see it it is a number or if it is not a number, and add to sorted list
                foreach (var t in mixedContentUnsorted)
                {
                    if (Regex.IsMatch(t, @"^\d+$"))
                    {
                        numbers.Add(t);
                    }
                    else
                    {
                        words.Add(t);
                    }
                }
                //create strings for the words and the numbers
                var printWords = string.Join(",", words);
                var printNumbers = string.Join(",", numbers);
                //if there are no words, print just the numbers
                if (words.Count == 0)
                {
                    Console.WriteLine(printNumbers);
                    break;
                }
                //if there are no numbers, print just the words
                if (numbers.Count == 0)
                {
                    Console.WriteLine(printWords);
                    break;
                }
                //if there are both numbers and letters, print the words first, seperate with a |, then print the numbers
                var printLine = string.Join("|", printWords, printNumbers);
                Console.WriteLine(printLine);
            }
            Console.ReadLine();
        }
    }
}
