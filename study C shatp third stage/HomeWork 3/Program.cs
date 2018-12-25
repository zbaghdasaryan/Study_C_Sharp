using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"dfjdhf(0.2569)a035{.6589}fgjk<2569>cvcvv[2365.0]cd";

            ShowFloatingPoints(text);
        }

        private static void ShowFloatingPoints(string input)
        {
            string pattern = @"[(][-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?[)]|[{][-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?\}|[<][-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?\>|[[][-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?\]";

            var collection = Regex.Matches(input, pattern);

            MatchCollection floatNumberCollection = Regex.Matches(input, pattern);

            foreach (var item in floatNumberCollection)
            {                
                Console.WriteLine(item.ToString().Substring(1, item.ToString().Length - 2));
            }
            Console.ReadKey();
        }
    }
}