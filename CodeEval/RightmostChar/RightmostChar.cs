using System;

//https://www.codeeval.com/open_challenges/31/
//To find the requirements for this project, visit the link above.

namespace RightmostChar
{
    class RightmostChar
    {
        static void Main(string[] args)
        {
            //read the file, a list of sentences with a comma seperated letter to be found
            string f = "RightmostCharFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //split the line into the sentence and the letter
                string[] result = line.Split(',');
                //find the letter to be indexed
                char[] designate = result[1].ToCharArray();
                //find the index of the letter
                int index = result[0].IndexOf(designate[0]);
                //print the index
                Console.WriteLine(index);
            }
            Console.ReadLine();
        }
    }
}
