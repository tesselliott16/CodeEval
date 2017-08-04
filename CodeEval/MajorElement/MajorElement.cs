using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorElement
{
    class MajorElement
    {
        static void Main(string[] args)
        {
            string f = "MajorElementsFile.txt";
            var list = new List<string>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int count;
                    int[] numbers = {0};
                    string isMajor = String.Empty;
                    string[] stringNumbers = line.Split(',');
                    for (int i = 0; i < stringNumbers.Length; i++)
                    {
                        int number = Convert.ToInt32(stringNumbers[i].Trim());
                        count = numbers.Count(x => x == number);
                        if (count > numbers.Length / 2)
                        {
                            isMajor = number.ToString();
                            break;
                        }
                        isMajor = "None\n";
                    }
                    Console.WriteLine(isMajor);
                }
            }
            Console.ReadLine();
        }
    }
}
