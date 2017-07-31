using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabernetOrChardonnay
{
    class CabernetOrChardonnay
    {
        static void Main(string[] args)
        {
            string f = "CabernetOrChardonnayFile.txt";
            StringBuilder builder = new StringBuilder();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] result = line.Split('|');
                    char[] toFind = result[1].Trim().ToCharArray();
                    string[] words = result[0].Trim().Split(' ');
                    List<bool> exist = new List<bool>();
                    foreach (string word in words)
                    {
                        foreach (char letter in toFind)
                        { 
                            bool letterExists = word.IndexOf(letter) != -1;
                            exist.Add(letterExists);
                        }
                        if (exist.Any(c => c == false))
                        {
                            exist.Clear();
                            continue;
                        }
                        builder.Append(word).Append(" ");
                    }
                    if (builder.Length == 0)
                    {
                        Console.WriteLine("False");
                    }
                    else
                    {
                        Console.WriteLine(builder.ToString());
                        builder.Clear();
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
