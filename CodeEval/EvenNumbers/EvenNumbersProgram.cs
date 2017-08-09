using System;
using StringGenerator;

//https://www.codeeval.com/open_challenges/100/
//Visit the above link to find the requirements for this project

namespace EvenNumbers
{
    class EvenNumbersProgram
    {
        static void Main(string[] args)
        {
            //generate a file with 30,000 randomly generated numbers up to 6 characters in length
            GenerateRandomString.CreateFile(30000, GenerateRandomString.GenerateType.Numbers, 6);
            string f = GenerateRandomString.FileName.GeneratedFilePath;
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //convert the string of numbers into an int
                int inputLine = Convert.ToInt32(line);
                //if the number is even (mod 2 = 0), print 1
                if (inputLine % 2 == 0)
                {
                    Console.WriteLine("1");
                }
                //if the number is odd (mod 2 = 1), print 0
                else
                {
                    Console.WriteLine("0");
                }
            }
            Console.ReadLine();  
        }
    }
}
