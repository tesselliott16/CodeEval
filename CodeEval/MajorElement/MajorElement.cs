using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codeeval.com/open_challenges/132/
//To find the requirements for this project, please visit the above link

namespace MajorElement
{
    class MajorElement
    {
        static void Main(string[] args)
        {
            //read the file, containing a comma seperated list of numbers
            string f = "MajorElementsFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                int count;
                List<int> numbers = new List<int>();
                string isMajor = String.Empty;
                //split the line on the comma
                string[] stringNumbers = line.Split(',');
                //convert each of the number strings to ints
                foreach (var number in stringNumbers)
                {
                    numbers.Add(Convert.ToInt32(number));
                }
                //find out how many times the number occurs on the list 
                for (int i = 0; i < numbers.Count; i++)
                {
                    int number = numbers[i];
                    count = numbers.Count(x => x == number);
                    //if the number occurs more times than 1/2 of the length of the total list, it is a major element
                    if (count > numbers.Count / 2)
                    {
                        isMajor = number.ToString();
                        break;
                    }
                    //if there is no major element, mark it as none
                    isMajor = "None\n";
                }
                //print the major element
                Console.WriteLine(isMajor);
            }
            Console.ReadLine();
        }
    }
}
