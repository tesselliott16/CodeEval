using System;
using System.Collections.Generic;
using System.Linq;
using StringGenerator;

//https://www.codeeval.com/open_challenges/24/
//To find the requirements of this project, visit the link above.
//This program is written to be as generic as possible, and should work with as many integers as needed

namespace SumOfIntegers
{
    class SumOfIntegersProgram
    {
        static void Main(string[] args)
        {
            //generate a file that contains two random numbers up to 4 characters in length
            GenerateRandomString.CreateFile(2, GenerateRandomString.GenerateType.Numbers, 4);
            string f = GenerateRandomString.FileName.GeneratedFilePath;
            List<int> intList = new List<int>();
            List<string> list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                intList.Add(Convert.ToInt32(line));
            }
            //sum up the list of integers
            int total = intList.Sum();
            //print the sum of the integers
            Console.WriteLine(total);
            Console.ReadLine();
        }

    }
}
