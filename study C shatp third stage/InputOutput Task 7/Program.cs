using System;
using System.IO;

// Запись в файл.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            // Создаем файл в текущем каталоге.
            var stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // Записываем байты в файл.
            for (int i = 0; i < 256; i++)
            {
                stream.WriteByte((byte)i);
            }

            Console.WriteLine(stream.Position);
            // Переставляем внутренний указатель на начало.
            stream.Position = 0;

            // Считывам байты из файла.
            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + stream.ReadByte());
            }

            // Закрываем FileStream. 
            stream.Close();

            // Delay.
            Console.ReadKey();
        }
    }
}
