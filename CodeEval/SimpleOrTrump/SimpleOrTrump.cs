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
            var cardList = new List<Card>();
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parseSplit = line.Split('|');
                    var handSplit = parseSplit[0].Trim().Split(' ');
                    var trumpSuit = parseSplit[1].Trim();
                    foreach (var card in handSplit)
                    {
                        var cardObject = new Card();
                        var cardParts = card.ToCharArray();
                        cardObject.CardSuit = cardParts[cardParts.Length - 1].ToString();
                        cardObject.CardFace = card.Substring(0, cardParts.Length-1);
                        cardObject.CardRank = CardValue(cardObject.CardSuit, cardObject.CardFace, trumpSuit);
                        cardList.Add(cardObject);
                    }
                    if (cardList[0].CardRank == cardList[1].CardRank)
                    {
                        Console.WriteLine(
                            $"{cardList[0].CardFace}{cardList[0].CardSuit} {cardList[1].CardFace}{cardList[1].CardSuit}");
                    }
                    else
                    {
                        var topCard = cardList.OrderByDescending(x => x.CardRank).ToList();
                        Console.WriteLine($"{topCard[0].CardFace}{topCard[0].CardSuit}");
                        topCard.Clear();
                    }
                    cardList.Clear();
                }
            }
            Console.Read();
        }

        public static int CardValue(string cardSuit, string cardFace, string trumpSuit)
        {
            int rankFaces = Array.IndexOf(Face.Faces, cardFace);
            if (cardSuit == trumpSuit)
            {
                rankFaces = rankFaces + 14;
                return rankFaces;
            }
            return rankFaces;
        }
        public class Face
        {
            public static string[] Faces = {"2", "3", "4", "5","6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        }
        public class Suit
        {
            public static char[] Suits = { 'C', 'H', 'S', 'D' };
        }
        public class Card
        {
            public string CardFace { get; set; }
            public string CardSuit { get; set; }
            public int CardRank { get; set; }
        }
    }
}
