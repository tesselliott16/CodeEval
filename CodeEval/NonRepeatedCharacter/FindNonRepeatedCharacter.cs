using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codeeval.com/open_challenges/12/
//To find the requirements for this project, visit the above link

namespace NonRepeatedCharacter
{
    class FindNonRepeatedCharacter
    {
        static void Main(string[] args)
        {
            //read a list of words on individual lines
            var f = "WordsListFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //read the word into a list
                var lettersAll = line.ToList();
                var distinctLetters = new List<char>();
                //find all of the distinct letters in the word
                var letters = lettersAll.Distinct().ToList();
                //find out how many times a letter occurs in the list
                foreach (var letter in letters)
                {
                    var count = lettersAll.Count(x => x == letter);
                    //if the letter occurs only once, add it to distinct letters list and stop looking, we want the first
                    if (count == 1)
                    {
                        distinctLetters.Add(letter);
                        break;
                    }
                }
                //print the distinct letter
                Console.WriteLine(distinctLetters[0].ToString());
            }
            Console.ReadLine();
        }
    }
}
