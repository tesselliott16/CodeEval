using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringGenerator;

namespace EvenNumbers
{
    class EvenNumbersProgram
    {
        static void Main(string[] args)
        {
            GenerateRandomString.CreateFile(30000, GenerateRandomString.GenerateType.Numbers, 6);
            string f = GenerateRandomString.FileName.GeneratedFilePath;
            List<char> finalList = new List<char>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int inputLine = Convert.ToInt32(line);
                    if (inputLine % 2 == 0)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
