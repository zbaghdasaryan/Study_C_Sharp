using System;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Сколько раз в этом цикле будет выполняться строка i = j - i;
            //int j = 2;
            //for (int i = 2; i < 32; i = i * 2)
            //{
            //    while (i < j)
            //    {
            //        j = j * 2;
            //    }
            //    i = j - i;
            //}

            //Что будет выведено на консоль в результате выполнения следующего цикла:
            for (int i = 1; i < 3; i++)
            {
                switch (i)
                {
                    default:
                        Console.WriteLine($"i = {i++}");
                        break;
                }
            }
        }
    }
}
