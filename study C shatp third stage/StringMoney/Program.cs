using System;
using System.Globalization;
using System.Windows.Forms;

// Вывод строк с использованием настроек культуры.

namespace StringBasics
{
    public class Program
    {
        static void Main()
        {
            // Сумма, которую необходимо вывести на экран.
            double money = 122343.45;

            // Три доступные культуры.
            var american = new CultureInfo("en-US");
            var germany = new CultureInfo("de-DE");
            var russian = new CultureInfo("ru-RU");

            // Форматируем строки под нужную культуру и сохраняем результат в переменной.
            string localMoney = money.ToString("C", american);
            string result = String.Format("Деньги США: {0}", localMoney);

            localMoney = money.ToString("C", germany);
            result += String.Format("\nДеньги Германии: {0}", localMoney);

            localMoney = money.ToString("C", russian);
            result += String.Format("\nДеньги России: {0}", localMoney);

            // Выводим содержимое на экран.
            MessageBox.Show(result);
        }
    }
}