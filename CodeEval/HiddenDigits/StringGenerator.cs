using System;
using System.IO;
using System.Linq;

namespace HiddenDigits
{
    class GenerateRandomString
    {
        public static Random random = new Random();
        public static void CreateFile(int numberOfStrings)
        {
            string line = string.Empty;
            
            FileName.GeneratedFilePath = @"C:\_Projects\CodeEval\CodeEval\HiddenDigits\GeneratedText\GeneratedText" + numberOfStrings + ".txt";
            if (!File.Exists(FileName.GeneratedFilePath))
            {
                File.Create(FileName.GeneratedFilePath).Dispose();
                using (var file = new System.IO.StreamWriter(FileName.GeneratedFilePath))
                {
                    for (int i = 0; i < numberOfStrings; i++)
                    {
                        int stringLength = random.Next(5, 15);
                        line = RandomString(stringLength);
                        file.WriteLine(line);
                    }
                }
            }
            if (File.Exists(FileName.GeneratedFilePath))
            {
                File.WriteAllText(FileName.GeneratedFilePath, string.Empty);
                using (var file = new System.IO.StreamWriter(FileName.GeneratedFilePath))
                {
                    for (int i = 0; i < numberOfStrings; i++)
                    {
                        int stringLength = random.Next(5, 15);
                        line = RandomString(stringLength);
                        file.WriteLine(line);
                    }
                }
            }
        }
        public static string RandomString(int length)
        {
            const string chars = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789[]{};':,./<>?!@#define$%^&*()\|=+`~";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static class FileName
        {
            public static string GeneratedFilePath { get; set; }
        }
    }
}

