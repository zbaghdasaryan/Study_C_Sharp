using System;
using System.IO;
using System.Reflection;

// Получение информации о файлах, хранящихся в директории.
// Для тестирования данного примера требуется, предварительно создать на диске D
// директорию TESTDIR и поместить в нее некоторое количество файлов с расширением .txt.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            var directory = new DirectoryInfo(@".");


            // Проверка на существование указанной директории.
            if (directory.Exists)
            {
                // Выводим информацию о каталоге.                
                Console.WriteLine("FullName    : {0}", directory.FullName);
                Console.WriteLine("Name        : {0}", directory.Name);
                Console.WriteLine("Parent      : {0}", directory.Parent);
                Console.WriteLine("CreationTime: {0}", directory.CreationTime);
                Console.WriteLine("Attributes  : {0}", directory.Attributes.ToString());
                Console.WriteLine("Root        : {0}", directory.Root);
                Console.Write("\n");

                // Получаем все файлы с расширением .txt.
                FileInfo[] files = directory.GetFiles("*.txt");

                // Сколько файлов с расширением .txt в данной директории.
                Console.WriteLine("Найдено {0} *.txt файлов\n", files.Length);

                // Выводим информацию о каждом файле.
                foreach (FileInfo file in files)
                {
                    Console.WriteLine("File name : {0}", file.Name);
                    Console.WriteLine("File size : {0}", file.Length);
                    Console.WriteLine("Creation  : {0}", file.CreationTime);
                    Console.WriteLine("Attributes: {0}", file.Attributes.ToString());
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
