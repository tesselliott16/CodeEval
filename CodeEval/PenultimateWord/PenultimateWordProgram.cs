using System;

//https://www.codeeval.com/open_challenges/92/
//To find the requirements for this project, visit the above link.

namespace PenultimateWord
{
    class PenultimateWordProgram
    {
        static void Main(string[] args)
        {
            //read the file, containing lists of words on single lines
            var f = "PenultimateWordFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //split the words into an array on the space
                var words = line.Split(' ');
                //print the word in the second to last
                Console.WriteLine(words[words.Length - 2]);
            }
            Console.ReadLine();
        }
    }
}
