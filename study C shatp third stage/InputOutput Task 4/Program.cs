using System;
using System.IO;

// Информация о дисках. Удаление директорий.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            // Выводим информацию о дисках.
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Имеющиеся диски:");

            foreach (string drive in drives)
                Console.WriteLine("- {0}", drive);

            var directory = new DirectoryInfo(@".");

            Console.WriteLine("\nГотовимся удалять:\n");
            Console.WriteLine(directory.FullName + @"\MyDir\SubMyDir");
            Console.WriteLine(directory.FullName + @"\SUBDIR");
            Console.WriteLine("\nНажмите Enter для удаления.\n");

            // Задержка перед удалением.
            Console.ReadKey();

            try
            {
                // Удаление каталогов.
                Directory.Delete(@".\SUBDIR");

                // Второй параметр определяет, будут ли удалены также и все вложенные подкаталоги. 
                Directory.Delete(@"D:\TESTDIR\MyDir", true);

                Console.WriteLine("Каталоги успешно удалены.");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            // Delay.
            Console.ReadKey();
        }
    }
}
