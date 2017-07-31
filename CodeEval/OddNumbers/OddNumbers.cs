using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    class OddNumbersProgram
    {
        static void Main(string[] args)
        {
            List<int> numbers = Enumerable.Range(1, 99).ToList();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    continue;
                }
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }
    }
}
