using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.RegularExpressions;

namespace HomeWork 2
{
    class Program
    {
        public static string OnlyBrackets(string text)
        {
            string brackets = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '{' || text[i] == '}' || text[i] == '['
                    || text[i] == ']' || text[i] == '<' || text[i] == '>'
                    || text[i] == '(' || text[i] == ')')
                {
                    brackets += text[i];
                }
            }
            return brackets;
        }

        public static string IsBracketTrueOrFals(string onlyParenthesestext)
        {
            string bracketstext = OnlyBrackets(onlyParenthesestext);
            while (bracketstext.Contains("{}") || bracketstext.Contains("[]")
                || bracketstext.Contains("<>") || bracketstext.Contains("()"))
            {
                bracketstext = bracketstext.Replace("{}", "");
                bracketstext = bracketstext.Replace("[]", "");
                bracketstext = bracketstext.Replace("<>", "");
                bracketstext = bracketstext.Replace("()", "");
            }
            if (bracketstext == null)
                return "brackets are put in the right places";
            else
            {
                Console.Write("brackets are put in the wrong place because there is ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(bracketstext);
                return null;
            }
        }

        static void Main(string[] args)
        {

            string text = "adfjkasd~#(*&$% .,//9[]/]   @_%^-_+?*-+fjl()af165!   #23  54af(dzksdj)kasjd<ss{}sdfs>)fl";

            Console.WriteLine(text);
            Console.WriteLine();
            IsBracketTrueOrFals(text);
            Console.ReadKey();
        }
    }
}
