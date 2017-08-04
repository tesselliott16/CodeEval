using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCharacters
{
    class RemoveCharactersProgram
    {
        static void Main(string[] args)
        {
            string f = "RemoveCharactersFile.txt";
            var list = new List<string>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] result = line.Split(',');
                    char[] foundLetters = result[1].Trim().ToCharArray();
                    char[] sentenceLetters = result[0].ToCharArray();
                    var sentence = result[0].ToList();
                    foreach (var letter in sentenceLetters)
                    {
                        if (foundLetters.Contains(letter))
                        {
                            sentence.Remove(letter);
                        }
                    }
                    Console.WriteLine(string.Join("",sentence));
                }
                Console.ReadLine();
            }
        }
    }
}
