using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringGenerator;

namespace SumOfIntegers
{
    class SumOfIntegersProgram
    {
        static void Main(string[] args)
        {
            GenerateRandomString.CreateFile(2, GenerateRandomString.GenerateType.Numbers, 4);
            string f = GenerateRandomString.FileName.GeneratedFilePath;
            List<int> intList = new List<int>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    intList.Add(Convert.ToInt32(line));
                }
            }
            int total = intList.Sum();
            Console.WriteLine(total);
            Console.ReadLine();
        }

    }
}
