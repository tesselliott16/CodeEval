using System;
using System.Collections.Generic;
using System.Linq;

//https://www.codeeval.com/open_challenges/25/
//To find the requirements for this project, visit the above link.

namespace OddNumbers
{
    class OddNumbersProgram
    {
        static void Main(string[] args)
        {
            //create a list of all of the numbers from 1 to 99
            List<int> numbers = Enumerable.Range(1, 99).ToList();
            foreach (int number in numbers)
            {
                //if the number is even (mod 2 = 0), skip it
                if (number % 2 == 0)
                {
                    continue;
                }
                //if the number is odd (mod 2 = 1), print it
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }
    }
}
