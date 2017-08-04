using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringGenerator;

namespace BigDigits
{
    class BigDigitConverter
    {
        static void Main(string[] args)
        {
            GenerateRandomString.CreateFile(1000, GenerateRandomString.GenerateType.Numeric, 5);
            string f = GenerateRandomString.FileName.GeneratedFilePath;
            StringBuilder builder = new StringBuilder();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] bigDigits = {string.Empty};
                    string[] printLine = {string.Empty};
                    char[] preParse = line.ToCharArray();
                    foreach (char digit in preParse)
                    {
                        if (char.IsDigit(digit))
                        {
                            int digitInt = Convert.ToInt32(char.GetNumericValue(digit));
                            bigDigits = ConvertToBigDigits(digitInt);
                        }
                        Array.Resize(ref printLine, bigDigits.Length);
                        for (int i = 0; i < bigDigits.Length; i++)
                        {
                            printLine[i] += String.Join(printLine[i], bigDigits[i]);
                        }
                    }
                    for (int i = 0; i < printLine.Length; i++)
                    {
                        Console.WriteLine(printLine[i]);
                    }
                   
                }
            }
            Console.ReadLine();
        }
        public static string[] ConvertToBigDigits(int digit)
        {
            if (digit == 0)
            {
                string[] number = {"-**--", "*--*-", "*--*-", "*--*-", "-**--", "-----"};
                return number;
            }
            if (digit == 1)
            {
                string[] number = { "--*--", "-**--", "--*--", "--*--", "-***-", "-----" };
                return number;
            }
            if (digit == 2)
            {
                string[] number = { "-***-", "----*", "--**-", "-*---", "-****", "-----" };
                return number;
            }
            if (digit == 3)
            {
                string[] number = { "-***-", "----*", "--**-", "----*", "-***-", "-----" };
                return number;
            }
            if (digit == 4)
            {
                string[] number = { "-*---", "*--*-", "****-", "---*-", "---*-", "-----" };
                return number;
            }
            if (digit == 5)
            {
                string[] number = { "-****", "-*---", "-***-", "----*", "-***-", "-----" };
                return number;
            }
            if (digit == 6)
            {
                string[] number = { "--**-", "-*---", "-***-", "-*--*", "--**-", "-----" };
                return number;
            }
            if (digit == 7)
            {
                string[] number = { "-****", "----*", "---*-", "--*--", "--*--", "-----" };
                return number;
            }
            if (digit == 8)
            {
                string[] number = { "--**-", "-*--*", "--**-", "-*--*", "--**-", "-----" };
                return number;
            }
            if (digit == 9)
            {
                string[] number = {"--**-", "-*--*", "--***", "----*", "--**-", "-----"};
                return number;
            }
            else return null;
        }
    }

        
}
