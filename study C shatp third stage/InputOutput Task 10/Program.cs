using System;
using System.IO;
using System.Text;

// Чтение/запись файлов.

namespace InputOutput
{
    class Program
    {
        static void Main()
        {
            // Создаем файл.
            //  var file = new FileInfo("Text.txt");

            // С помощью экземпляра StreamWriter записываем в файл несколько строк текста.
            //      StreamWriter writer = file.CreateText();

            var file2 = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            var writer = new StreamWriter(file2, Encoding.GetEncoding(1251));


            writer.WriteLine("Первая строка текста...");

            writer.WriteLine("Вторая строка текста...");

            // Вставляем символ начала новой строки.
            writer.Write(writer.NewLine);

            writer.WriteLine("Третья строка чисел:");

            for (int i = 0; i < 10; i++)
            {
                writer.Write(i + " ");
            }

            // Метод Close() автоматически очищает все буферы.
            writer.Close();

            Console.WriteLine("Файл Text.txt создан и в него записан текст.");

            // Выводим информацию из файла на консоль при помощи StreamReader. 
            Console.WriteLine("Содержимое файла Text.txt:\n");

            StreamReader reader = File.OpenText("Text.txt");
            string input;

            // Выводим содержимое файла в консоль.
            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }

            reader.Close();

            // Delay.
            Console.ReadKey();
        }
    }
}
