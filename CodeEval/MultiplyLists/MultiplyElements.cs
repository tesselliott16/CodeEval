using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codeeval.com/open_challenges/113/
//To find the requirements for this project, visit the link above.

namespace MultiplyElements
{
    class MultiplyElements
    {
        private static void Main(string[] args)
        {
            //read the file, which contains two lists to be multiplied pairwise, seperated by a |
            var f = "MultiplyListsFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //split the two lists apart on the |
                var result = line.Split('|');
                //split each of the lists of numbers into arrays
                var right = result[0].Split(' ');
                var rightInt = Array.ConvertAll(right, int.Parse);
                var left = result[1].Split(' ');
                var leftInt = Array.ConvertAll(left, int.Parse);
                var final = new List<int>();
                //multiply the two matching components in the two lists
                for (var c = 0; c < right.Length; c++)
                {
                    var result2 = Multiply(rightInt[c], leftInt[c]);
                    final.Add(result2);
                }
                //print the results in order
                Console.WriteLine(string.Join(" ", final.Select(x => x.ToString()).ToArray()));
            }
                Console.ReadLine();
        }

        //basic multiplication method 
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
