using System;
using StringGenerator;
using static System.Char;

//https://www.codeeval.com/open_challenges/163/
// This project has been developed from the requirements in the above link

namespace BigDigits
{
    class BigDigitConverter
    {
        static void Main(string[] args)
        {
            //generate a file with 1000 random strings that are up to 5 digits in length
            GenerateRandomString.CreateFile(1000, GenerateRandomString.GenerateType.Numeric, 5);
            var f = GenerateRandomString.FileName.GeneratedFilePath;
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                string[] bigDigits = { string.Empty };
                string[] printLine = { string.Empty };
                var preParse = line.ToCharArray();
                //for each character in the character array of the line of numbers
                foreach (var digit in preParse)
                {
                    //ignoring any character that isn't a number
                    if (IsDigit(digit))
                    {
                        //convert the character into an int
                        var digitInt = Convert.ToInt32(GetNumericValue(digit));
                        //pass the character into the Conversion method (see below)
                        bigDigits = ConvertToBigDigits(digitInt);
                    }
                    //create array of the size of the bigDigit's array
                    Array.Resize(ref printLine, bigDigits.Length);
                    //join the bigDigits array to the printLine array in order to print each of lines correctly for all of the characters
                    for (var i = 0; i < bigDigits.Length; i++)
                    {
                        printLine[i] += string.Join(printLine[i], bigDigits[i]);
                    }
                }
                //print each of the lines for each of the digits
                foreach (var t in printLine)
                {
                    Console.WriteLine(t);
                }
            }
            Console.ReadLine();
        }
        public static string[] ConvertToBigDigits(int digit)
        {
            //here the strings for each number are declared and the numbers passed in and the strings are sent back out
            switch (digit)
            {
                case 0:
                {
                    string[] number = {"-**--", "*--*-", "*--*-", "*--*-", "-**--", "-----"};
                    return number;
                }
                case 1:
                {
                    string[] number = { "--*--", "-**--", "--*--", "--*--", "-***-", "-----" };
                    return number;
                }
                case 2:
                {
                    string[] number = { "-***-", "----*", "--**-", "-*---", "-****", "-----" };
                    return number;
                }
                case 3:
                {
                    string[] number = { "-***-", "----*", "--**-", "----*", "-***-", "-----" };
                    return number;
                }
                case 4:
                {
                    string[] number = { "-*---", "*--*-", "****-", "---*-", "---*-", "-----" };
                    return number;
                }
                case 5:
                {
                    string[] number = { "-****", "-*---", "-***-", "----*", "-***-", "-----" };
                    return number;
                }
                case 6:
                {
                    string[] number = { "--**-", "-*---", "-***-", "-*--*", "--**-", "-----" };
                    return number;
                }
                case 7:
                {
                    string[] number = { "-****", "----*", "---*-", "--*--", "--*--", "-----" };
                    return number;
                }
                case 8:
                {
                    string[] number = { "--**-", "-*--*", "--**-", "-*--*", "--**-", "-----" };
                    return number;
                }
                case 9:
                {
                    string[] number = {"--**-", "-*--*", "--***", "----*", "--**-", "-----"};
                    return number;
                }
                default:
                    return null;
            }
        }
    }

        
}
