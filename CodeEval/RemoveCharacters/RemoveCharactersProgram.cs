using System;
using System.Linq;

//https://www.codeeval.com/open_challenges/13/
//To find the requirements for this project, visit the link above.

namespace RemoveCharacters
{
    class RemoveCharactersProgram
    {
        static void Main(string[] args)
        {
            //read the file, which contains a sentence, then a set of characters to be removed seperated by a comma
            string f = "RemoveCharactersFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //seperate the sentence from the characters to remove
                string[] result = line.Split(',');
                //turn the characters to be removed to a char array
                char[] foundLetters = result[1].Trim().ToCharArray();
                //turn the sentence into a char array
                var sentence = result[0].ToList();
                //for each letter in the removal list, remove the letter from the sentence array
                foreach (var letter in foundLetters)
                {
                    if (sentence.Contains(letter))
                    {
                        sentence.Remove(letter);
                    }
                }
                //put the sentence back together
                Console.WriteLine(string.Join("", sentence));
            }
                Console.ReadLine();
        }
    }
}
