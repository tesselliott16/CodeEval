using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrTrump
{
    class SimpleOrTrump
    {
        static void Main(string[] args)
        {
            string f = "SimpleOrTrumpFile.txt";
            var list = new List<string>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string largestCard = null;
                    string[] parseSplit = line.Split('|');
                    string[] handSplit = parseSplit[0].Trim().Split(' ');
                    string trumpSplit = parseSplit[1].Trim();
                    for (int i = 0; i < handSplit.Length; i++)
                    {
                        if (handSplit[i].Contains(trumpSplit) && handSplit[i+1].Contains(trumpSplit))
                        {
                            char faceCardOne = Convert.ToChar(handSplit[i].Trim(Convert.ToChar(trumpSplit)));
                            char faceCardTwo = Convert.ToChar(handSplit[i+1].Trim(Convert.ToChar(trumpSplit)));
                            if (char.IsNumber(faceCardOne) && char.IsNumber(faceCardTwo))
                            {
                                largestCard = (Math.Max(char.GetNumericValue(faceCardOne), char.GetNumericValue(faceCardTwo))).ToString();
                            }
                            if (char.IsLetter(faceCardOne) || char.IsLetter(faceCardTwo))
                            {
                                
                            }
                            Console.WriteLine(largestCard + trumpSplit);
                        }
                    }
                    
                }
            }
        }

        public static class Ranked
        {
            public static string[] Suits = {"C", "H", "S", "D"};
            public static string[] Faces = {"J", "Q", "K", "A"};
        }
    }
}
