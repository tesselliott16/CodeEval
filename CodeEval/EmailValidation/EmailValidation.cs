using System;
using System.Text.RegularExpressions;

//https://www.codeeval.com/open_challenges/35/
//Visit the above link for the requirements for this project

namespace EmailValidation
{
    class EmailValidation
    {
        static void Main(string[] args)
        {
            //read a list of emails
            var f = "EmailListFile.txt";
            var list = FileSize.FileReader.FileReaderInit(f);
            foreach (var line in list)
            {
                //determine if the email matches a typical email regex
                var isEmail =
                    Regex.IsMatch(line,
                        @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
                //print the true or false of the email's match to the email regex
                Console.WriteLine(isEmail);
            }
            Console.ReadLine();
        }
    }
}
