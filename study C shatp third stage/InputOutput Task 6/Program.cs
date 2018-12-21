using System;
using System.IO;

// Создание/удаление файла.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            // Создаем новый файл в корне диска D:
            var file = new FileInfo(@"D:\Test\Test.txt");

            // FileMode.OpenOrCreate - ЕСЛИ: существует ТО: открыть ИНАЧЕ: создать новый
            // FileAccess.Read - только для чтения,
            // FileShare.None - Совместный доступ - Нет.
            FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);

            // Выводим основную информацию о созданном файле.            
            Console.WriteLine("Full Name   : {0}", file.FullName);
            Console.WriteLine("Attributes  : {0}", file.Attributes.ToString());
            Console.WriteLine("CreationTime: {0}", file.CreationTime);

            Console.WriteLine("Нажмите любую клавишу для удаления файла.");
            Console.ReadKey();

            // Закрываем FileStream. 
            stream.Close();

            // Удаляем файл.
            file.Delete();

            Console.WriteLine("Файл успешно удален.");

            // Delay.
            Console.ReadKey();
        }
    }
}
