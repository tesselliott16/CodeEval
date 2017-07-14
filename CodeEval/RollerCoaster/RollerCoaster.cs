using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoaster
{
    class RollerCoaster
    {
        static void Main(string[] args)
        {
            string f = "RollerCoasterText.txt";
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    StringBuilder str = new StringBuilder();
                    bool uppercase = true;
                    char[] sentence = line.ToCharArray();
                    foreach (char letter in sentence)
                    {
                        if (char.IsLetter(letter))
                        {
                            if (uppercase)
                            {
                                str.Append(char.ToUpper(letter));
                            }
                            else
                            {
                                str.Append(char.ToLower(letter));
                            }
                            uppercase = !uppercase;
                        }
                        else
                        {
                            str.Append(letter);
                        }
                    }
                    string finalSentence = str.ToString();
                    Console.WriteLine(finalSentence);
                }
                Console.ReadLine();
            }
        }
    }
}
