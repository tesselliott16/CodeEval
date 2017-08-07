using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRepeatedCharacter
{
    class FindNonRepeatedCharacter
    {
        static void Main(string[] args)
        {
            string f = "WordsListFile.txt";
            var list = new List<string>();
            StringBuilder builder = new StringBuilder();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int count;
                    List<char> lettersAll = line.ToList();
                    List<char> letters = new List<char>();
                    List<char> distinctLetters = new List<char>();
                    letters = lettersAll.Distinct().ToList();
                    foreach (char letter in letters)
                    {
                        count = lettersAll.Count(x => x == letter);
                        if (count == 1)
                        {
                            distinctLetters.Add(letter);
                            break;
                        }
                    }
                    Console.WriteLine(distinctLetters[0].ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
