using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightmostChar
{
    class RightmostChar
    {
        static void Main(string[] args)
        {
            string f = "RightmostCharFile.txt";
            var list = new List<string>();
            var fileStream = new FileStream(f, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] result = line.Split(',');
                    char[] designate = result[1].ToCharArray();
                    int index = result[0].IndexOf(designate[0]);
                    Console.WriteLine(index);
                }
                Console.ReadLine();
            }
        }
    }
}
