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
            
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("a", "ա");
            dic.Add("b", "բ");
            dic.Add("g", "գ");
            dic.Add("d", "դ");
            dic.Add("ye", "ե");
            dic.Add("z", "զ");
            dic.Add("e", "է");
            dic.Add("@", "ը");
            dic.Add("th", "թ");
            dic.Add("j", "ժ");
            dic.Add("i", "ի");
            dic.Add("l", "լ");
            dic.Add("kh", "խ");
            dic.Add("tc", "ծ");
            dic.Add("k", "կ");
            dic.Add("h", "հ");
            dic.Add("dz", "ձ");
            dic.Add("x", "ղ");
            dic.Add("tch", "ճ");
            dic.Add("m", "մ");
            dic.Add("y", "յ");
            dic.Add("n", "ն");
            dic.Add("sh", "շ");
            dic.Add("vo", "ո");
            dic.Add("ch", "չ");
            dic.Add("p", "պ");
            dic.Add("dj", "ջ");
            dic.Add("ry", "ռ");
            dic.Add("s", "ս");
            dic.Add("v", "վ");
            dic.Add("t", "տ");
            dic.Add("r", "ր");
            dic.Add("c", "ց");
            dic.Add("u", "ու");
            dic.Add("ph", "փ");
            dic.Add("q", "ք");
            dic.Add("yev", "և");
            dic.Add("o", "օ");
            dic.Add("f", "ֆ");


            foreach (var item in dic.Keys)
            {
                Console.WriteLine($"{item} - {dic[item]}");
            }



            Console.OutputEncoding = Encoding.UTF8;
            string input = "";
            while (true)
            {


                input += Console.ReadKey().KeyChar;


            }
        }
    }
}