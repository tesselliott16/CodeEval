using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codeeval.com/open_challenges/167/
//To find the requirements for this project, visit the link above.

namespace ReadMore
{
    class ReadMoreProgram
    {
        static void Main(string[] args)
        {
            //read a file with lists of sentences
            string f = "ReadMoreFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                var foundIndexes = new List<int>();
                //turn the sentence into a char array
                char[] lineArray = line.ToCharArray();
                if (line.Length > 55)
                {
                    for (int i = 0; i < lineArray.Length; i++)
                    {
                        //find and save the indexes of all of the spaces in the list
                        if (lineArray[i] == ' ')
                        {
                            foundIndexes.Add(i);
                        }
                    }
                    //trim the list of indexes of spaces to only go up to 40, since we are chopping the list to 40 char
                    var trimIndexes = new List<int>();
                    for (int i = 0; i < foundIndexes.Count; i++)
                    {
                        if (foundIndexes[i] < 40)
                        {
                            trimIndexes.Add(foundIndexes[i]);
                        }
                    }
                    int length = trimIndexes.Count;
                    //find the spot where the space lives to cut to it
                    int cutPoint = trimIndexes[length - 1];
                    //trim the string to the final space
                    string finalTrim = string.Concat(line.Take(cutPoint));
                    //add the read more tag to the end of the sentence when printing
                    Console.WriteLine(finalTrim + ". . . <Read More>");
                }
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
