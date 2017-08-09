using System;
using System.Collections.Generic;
using System.Text;

//https://www.codeeval.com/open_challenges/156/
//To find the requirements for this project, visit the link above.

namespace RollerCoaster
{
    class RollerCoaster
    {
        static void Main(string[] args)
        {
            //read the file of strings
            string f = "RollerCoasterText.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var sentence in list)
            {
                var sentenceConstruct = new List<char>();
                StringBuilder str = new StringBuilder();
                bool uppercase = true;
                //turn the string into a char array
                char[] sentenceNormal = sentence.ToCharArray();
                //make each letter lowercase to start 
                foreach (var letter in sentenceNormal)
                {
                    sentenceConstruct.Add(char.ToLower(letter));
                }
                foreach (char letter in sentence)
                {
                    if (char.IsLetter(letter))
                    {
                        //if uppercase is true, make the letter uppercase (will always start uppercase)
                        if (uppercase)
                        {
                            str.Append(char.ToUpper(letter));
                        }
                        //if uppercase is false, make letter lowercase
                        else
                        {
                            str.Append(char.ToLower(letter));
                        }
                        //flip uppercase from true to false (causes alternation)
                        uppercase = !uppercase;
                    }
                    //if not a lettter, add as is
                    else
                    {
                        str.Append(letter);
                    }
                }
                //put the sentence back together and print
                string finalSentence = str.ToString();
                Console.WriteLine(finalSentence);
                Console.ReadLine();
            }
        }
    }
}
