using System;
using System.Collections.Generic;
using System.Text;

//https://www.codeeval.com/open_challenges/96/
//To find the requirements for this project, visit the link above.

namespace SwapCase
{
    class SwapInputCase
    {
        static void Main(string[] args)
        {
            //takes a list of sentences
            string f = "SwapCaseFile.txt";
            var sentences = FileSize.FileReader.FileReaderInit(f);
            List<char> finalList = new List<char>();
            //close the reader and mess with each sentence
            foreach (var sentence in sentences)
            {
                //turns the sentence into a char array
                char[] inputLine = sentence.ToCharArray();
                //for each letter in the sentence
                foreach (char letter in inputLine)
                {
                    var letterAdjusted = new char();
                    //if the char is lower, make it upper
                    if (char.IsLower(letter))
                    {
                        letterAdjusted = char.ToUpper(letter);
                        //add the letter to the adjusted letter list
                        finalList.Add(letterAdjusted);
                        continue;
                    }
                    //if the char is upper, make it lower
                    if (char.IsUpper(letter))
                    {
                        letterAdjusted = char.ToLower(letter);
                        //add the letter to the adjusted letter list
                        finalList.Add(letterAdjusted);
                        continue;
                    }
                    //if the char is not a letter, leave it alone
                    else
                    {
                        finalList.Add(letter);
                        continue;
                    }
                }
                StringBuilder builder = new StringBuilder();
                //build the sentence back up with the adjusted letters
                foreach (char letter in finalList)
                {
                    builder.Append(letter);
                }
                //print the sentence
                Console.WriteLine(builder.ToString());
                //clear the sentences for the next list
                builder.Clear();
                finalList.Clear();
            }
            Console.ReadLine();
        }
    }
}
