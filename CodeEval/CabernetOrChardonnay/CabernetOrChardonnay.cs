using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codeeval.com/open_challenges/211/
//Find the requirements for the project below at the above link

namespace CabernetOrChardonnay
{
    class CabernetOrChardonnay
    {
        static void Main(string[] args)
        {
            //read the file in the project that contains the wine types and the remembered characters
            string f = "CabernetOrChardonnayFile.txt";
            var builder = new StringBuilder();
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //split the words from the remembered characters
                var result = line.Split('|');
                //save the remembered charcters to a char array
                var toFind = result[1].Trim().ToCharArray();
                //split the words into seperate strings and save in a string array
                var words = result[0].Trim().Split(' ');
                var exist = new List<bool>();
                //for each word in the string array of words
                foreach (var word in words)
                {
                    //for each letter in the character array of remembered characters
                    exist.AddRange(toFind.Select(letter => word.IndexOf(letter) != -1));
                    //if there is a false in the list, clear the list and move on to the next word
                    if (exist.Any(c => c == false))
                    {
                        exist.Clear();
                        continue;
                    }
                    //if all of the letters exist in the word, add the word to the list to print and move on to the next word
                    builder.Append(word).Append(" ");
                }
                //if there are no words that contain the required letters, print false
                if (builder.Length == 0)
                {
                    Console.WriteLine("False");
                }
                //print the words that contain the required letters
                else
                {
                    Console.WriteLine(builder.ToString());
                    builder.Clear();
                }
            }
            Console.ReadLine();
        }
    }
}
