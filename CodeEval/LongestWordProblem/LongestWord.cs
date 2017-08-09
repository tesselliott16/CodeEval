using System;

//https://www.codeeval.com/open_challenges/111/
//To find the requirements of the below project, click the link above

namespace LongestWordProblem
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            //read the file of lines containing multiple words
            string f = "LongestWordFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                string longestLength = string.Empty;
                //split the list of words on the space
                string[] result = line.Split(' ');
                for (int i = 0; i < result.Length; i++)
                {
                    //set the variable that would contain the longest word to the first word in the list
                    if (i == 0)
                    {
                        longestLength = result[i];
                    }
                    //add the longest string from the current longest string and the existing longest string, and save the result as the new longest string
                    //pass both strings into the method to determine which is the longest
                    if (i > 0)
                    {
                        longestLength = StringLength(longestLength, result[i]);
                    }
                }
                //print the longest string in the line
                Console.WriteLine(longestLength);
            }
            Console.ReadLine();
        }
        //determine the longest string of the two that are passed in
        static string StringLength(string x, string y)
        {
            int xLength = x.Length;
            int yLength = y.Length;
            if (xLength == yLength)
            {
                return x;
            }
            else
            {
                return x.Length > y.Length ? x : y;
            }
        }
    }
}
