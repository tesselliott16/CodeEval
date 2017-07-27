using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HiddenDigits
{
    class HiddenDigits
    {
        static void Main(string[] args)
        {
            GenerateRandomString.CreateFile(50);
            string f = GenerateRandomString.FileName.GeneratedFilePath;
            var list = new List<string>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<char> hiddenList = new List<char>() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};
                    List<int> hiddenDigits = new List<int>();
                    char[] designate = line.ToCharArray();
                    foreach (char letter in designate)
                    {
                        if (char.IsLower(letter) && hiddenList.Contains(letter))
                        {
                            hiddenDigits.Add(hiddenList.IndexOf(letter));
                        }
                        if (char.IsDigit(letter))
                        {;
                            hiddenDigits.Add(Convert.ToInt32(char.GetNumericValue(letter)));
                        }
                    }
                    if (hiddenDigits.Count == 0)
                    {
                        Console.WriteLine("NULL");
                    }
                    else
                    {
                        StringBuilder builder = new StringBuilder();
                        foreach (int digit in hiddenDigits)
                        {
                            builder.Append(digit).Append("");
                        }
                        Console.WriteLine(builder.ToString());
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
