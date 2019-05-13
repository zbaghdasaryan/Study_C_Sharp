using System;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {

           //Сколько раз в этом цикле будет выполняться строка i = j - i;
            int j = 2;
            for (int i = 2; i < 32; i = i * 2)
            {
                while (i < j)
                {
                    j = j * 2;
                }
                i = j - i;
            }
        }
    }
}
