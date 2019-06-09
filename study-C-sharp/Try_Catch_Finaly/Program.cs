using System;

namespace Try_Catch_Finaly
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
            Console.Read();
        }
    }
}
