using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

//https://www.codeeval.com/open_challenges/128/
//The requirements for the project below can be found at the above link

namespace CompressedSequence
{
    class CompressedSequence
    {
        static void Main(string[] args)
        {
            //read the required file within the project
            string f = "CompressedSequenceFile.txt";
            var list = new List<string>();
            StringBuilder builder = new StringBuilder();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //read a single line of the file
                    int count;
                    List<int> numbersAll = new List<int>();
                    List<int> numbers = new List<int>();
                    //parse the line into an array of numbers on the spaces
                    string[] stringNumbers = line.Split(' ');
                    //for each number in the string, convert to an int and add to a list of ints
                    foreach (var number in stringNumbers)
                    {
                        numbersAll.Add(Convert.ToInt32(number));
                    }
                    //create a list of all of the distinct numbers in the list
                    numbers = numbersAll.Distinct().ToList();
                    //find out how many times the distinct numbers occur in the list of all numbers
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];
                        //use linq to count the number of occurences of the distinct number in the overall number list
                        count = numbersAll.Count(x => x == number);
                        //building a string that will list the number of times the number occurs, then the number itself
                        builder.Append(count + " " + number).Append(" ");
                    }
                    //print the list of the number of times each number in the line exists
                    Console.WriteLine(builder.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
