using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('a', 'ա');
            dic.Add('b', 'բ');
            dic.Add('g', 'գ');
            dic.Add('d', 'դ');
            dic.Add('e', 'ե');
            dic.Add('z', 'զ');
            dic.Add('1', 'է');
            dic.Add('y', 'ը');
            dic.Add('2', 'թ');
            dic.Add('=', 'ժ');
            dic.Add('i', 'ի');
            dic.Add('l', 'լ');
            dic.Add('[', 'խ');
            dic.Add(']', 'ծ');
            dic.Add('k', 'կ');
            dic.Add('h', 'հ');
            dic.Add('4', 'ձ');
            dic.Add('x', 'ղ');
            dic.Add('0', 'ճ');
            dic.Add('m', 'մ');
            dic.Add('j', 'յ');
            dic.Add('n', 'ն');
            dic.Add('\\', 'շ');
            dic.Add('w', 'ո');
            dic.Add('9', 'չ');
            dic.Add('p', 'պ');
            dic.Add('5', 'ջ');
            dic.Add('r', 'ռ');
            dic.Add('s', 'ս');
            dic.Add('v', 'վ');
            dic.Add('t', 'տ');
            dic.Add('8', 'ր');
            dic.Add('c', 'ց');
            dic.Add('u', 'ւ');
            dic.Add('3', 'փ');
            dic.Add('q', 'ք');
            dic.Add('7', 'և');
            dic.Add('o', 'օ');
            dic.Add('f', 'ֆ');

            //foreach (var item in dic.Keys)
            //    Console.WriteLine($"{item} - {dic[item]}");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(dic[text[i]]);

            }
            Console.ReadKey();
            //string s = "";
            //while (true)
            //{
            //    char input = Console.ReadKey().KeyChar;
            //    if (input == '\r')
            //        break;
            //    s += input;
            //}
            //Console.WriteLine();

            //string output = "";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    try
            //    {
            //        output += dic[s[i]];
            //    }
            //    catch
            //    {
            //        output += s[i];
            //    }
            //}
            //Console.WriteLine(output);
        }
    }
}