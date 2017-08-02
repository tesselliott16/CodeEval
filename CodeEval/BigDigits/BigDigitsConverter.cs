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
            GenerateRandomString.CreateFile(10, GenerateRandomString.GenerateType.Numeric, 20);
            string f = GenerateRandomString.FileName.GeneratedFilePath;
            StringBuilder builder = new StringBuilder();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] bigDigits;
                    char[] preParse = line.ToCharArray();
                    foreach (char digit in preParse)
                    {
                        if (char.IsDigit(digit))
                        {
                            int digitInt = Convert.ToInt32(char.GetNumericValue(digit));
                            bigDigits = ConvertToBigDigits(digitInt);
                        }
                    }
                    for (int i = 0; i < bigDigits.Length / 2; i++)
                    {
                        builder.Append(bigDigits[i], bigDigits[i+6]);
                    }
                    Console.WriteLine(builder.ToString());
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
                string[] number = { "--*--", "-*--*", "-****", "----*", "----*", "-----" };
                return number;
            }
            if (digit == 5)
            {
                string[] number = { "-****", "-*---", "-***-", "----*", "-***-", "-----" };
                return number;
            }
            if (digit == 6)
            {
                string[] number = { "--**-", "-***-", "-*--*", "*--*-", "--**-", "-----" };
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
                string[] number = { "--**-", "-*--*", "--***", "----*", "--**-", "-----" };
                return number;
            }
        }
    }

        
}
