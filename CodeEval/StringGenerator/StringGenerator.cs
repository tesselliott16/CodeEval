using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace StringGenerator
{
    public class GenerateRandomString
    {
        static void Main()
        {
        }
        public static Random random = new Random();
        public static void CreateFile(int numberOfStrings, string charType, int maxLength)
        {
            string line = string.Empty;
            FileName.GeneratedFilePath = @"C:\_Projects\CodeEval\CodeEval\GeneratedText\GeneratedText" + numberOfStrings + FileName.DateTime.ToString("Mmddyyhmmss") + ".txt";
            if (!File.Exists(FileName.GeneratedFilePath))
            {
                File.Create(FileName.GeneratedFilePath).Dispose();
                using (var file = new System.IO.StreamWriter(FileName.GeneratedFilePath))
                {
                    for (int i = 0; i < numberOfStrings; i++)
                    {
                        int stringLength = random.Next(3, maxLength);
                        line = RandomString(stringLength, charType);
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
                        int stringLength = random.Next(3, maxLength);
                        line = RandomString(stringLength, charType);
                        file.WriteLine(line);
                    }
                }
            }
        }
        public static string RandomString(int length, string chars)
        {
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static class FileName
        {
            public static string GeneratedFilePath { get; set; }
            public static DateTime DateTime { get; set; } = DateTime.Today;
        }

        public static class GenerateType
        {
            public static string AllKeys = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789[]{};':,./<>?!@#define$%^&*()\|=+`~";
            public static string Numbers = "0123456789";
            public static string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            public static string Lower = "abcdefghijklmnopqrstuvwxyz";
            public static string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            public static string Numeric = "0123456789.";
        }
    }
}

