using System;
using System.Collections.Generic;
using System.Text;
using StringGenerator;
using static System.Char;

//https://www.codeeval.com/open_challenges/122/
//Visit the above link to find the requirements for this project

namespace HiddenDigits
{
    class HiddenDigits
    {
        static void Main(string[] args)
        {
            //generate a file with 30,000 random strings containing up to 20 random keystrokes from the keyboard
            GenerateRandomString.CreateFile(30000, GenerateRandomString.GenerateType.AllKeys, 20);
            string f = GenerateRandomString.FileName.GeneratedFilePath;
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //the below list of characters should be converted into their index if the character is found in the string
                var hiddenList = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
                var hiddenDigits = new List<int>();
                var designate = line.ToCharArray();
                //go through each character in line
                foreach (var letter in designate)
                {
                    //if the character is in the list of hidden characters, add the index of the characters
                    if (hiddenList.Contains(letter))
                    {
                        hiddenDigits.Add(hiddenList.IndexOf(letter));
                    }
                    //if the character is a digit, leave the character where it is
                    if (IsDigit(letter))
                    {
                        hiddenDigits.Add(Convert.ToInt32(GetNumericValue(letter)));
                    }
                }
                //if there were no hiddenDigits or numbers, print NULL
                if (hiddenDigits.Count == 0)
                {
                    Console.WriteLine("NULL");
                }
                //otherwise, print the string of numbers generated from the existing numbers and hidden digits
                else
                {
                    var builder = new StringBuilder();
                    foreach (var digit in hiddenDigits)
                    {
                        builder.Append(digit).Append("");
                    }
                    Console.WriteLine(builder.ToString());
                }
            }
            Console.ReadLine();
        } 
    }
}
