using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CompressedSequence
{
    class CompressedSequence
    {
        static void Main(string[] args)
        {
            string f = "CompressedSequenceFile.txt";
            var list = new List<string>();
            StringBuilder builder = new StringBuilder();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int count;
                    List<int> numbersAll = new List<int>();
                    List<int> numbers = new List<int>();
                    string isMajor = String.Empty;
                    string[] stringNumbers = line.Split(' ');
                    foreach (var number in stringNumbers)
                    {
                        numbersAll.Add(Convert.ToInt32(number));
                    }
                    numbers = numbersAll.Distinct().ToList();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];
                        count = numbersAll.Count(x => x == number);
                        builder.Append(count + " " + number).Append(" ");
                    }
                    Console.WriteLine(builder.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
