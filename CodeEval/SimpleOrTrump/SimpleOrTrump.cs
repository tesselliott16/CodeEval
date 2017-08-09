using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codeeval.com/open_challenges/235/
//To find the requirements for this project, visit the above link.

namespace SimpleOrTrump
{
    class SimpleOrTrump
    {
        static void Main(string[] args)
        {
            //read the file, which lists two cards (number suit) | trump suit
            string f = "SimpleOrTrumpFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            var cardList = new List<Card>();
            foreach (var hand in list)
            {
                //split the line to get the cards and the trump
                var parseSplit = hand.Split('|');
                //split the hand into two cards and trim all
                var handSplit = parseSplit[0].Trim().Split(' ');
                //trim the trump suit
                var trumpSuit = parseSplit[1].Trim();
                //create the cards
                foreach (var card in handSplit)
                {
                    //make a new card object (see below)
                    var cardObject = new Card();
                    //split the card parts into a char array
                    var cardParts = card.ToCharArray();
                    //add the card suit to the object by taking the last character of the card
                    cardObject.CardSuit = cardParts[cardParts.Length - 1].ToString();
                    //add the card face to the object by taking the characters that come before the suit
                    cardObject.CardFace = card.Substring(0, cardParts.Length - 1);
                    //calculate the rank
                    cardObject.CardRank = CardValue(cardObject.CardSuit, cardObject.CardFace, trumpSuit);
                    //add the card object to a list of card objects so they can be compared
                    cardList.Add(cardObject);
                }
                //if the card rank is the same for both cards, print both cards
                if (cardList[0].CardRank == cardList[1].CardRank)
                {
                    Console.WriteLine(
                        $"{cardList[0].CardFace}{cardList[0].CardSuit} {cardList[1].CardFace}{cardList[1].CardSuit}");
                }
                //print the card with the highest rank
                else
                {
                    var topCard = cardList.OrderByDescending(x => x.CardRank).ToList();
                    Console.WriteLine($"{topCard[0].CardFace}{topCard[0].CardSuit}");
                    topCard.Clear();
                }
                cardList.Clear();
            }
            Console.Read();
        }

        //find the rank of the card
        public static int CardValue(string cardSuit, string cardFace, string trumpSuit)
        {
            //index of the face in the face array to give the face a value 
            string[] Faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int rankFaces = Array.IndexOf(Faces, cardFace);
            //if the card has the trump suit, add 14 to make it higher than any other possible card (even 2 vs A)
            //if both cards have trump, both will have the 14 increment
            if (cardSuit == trumpSuit)
            {
                rankFaces = rankFaces + 14;
                return rankFaces;
            }
            return rankFaces;
        }
        //class to create the card that has three attributes; face, suit and rank
        public class Card
        {
            public string CardFace { get; set; }
            public string CardSuit { get; set; }
            public int CardRank { get; set; }
        }
    }
}
