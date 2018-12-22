using System;
using System.Globalization;

// Использование интерфейса IFormattable.

namespace StringBasics
{
    
    public class Temperature : IFormattable
    {
        private decimal temperature;

        public Temperature(decimal temperature)
        {
            if (temperature < -273.15m) // -273.15m - Абсолютный ноль!
            {
                throw new ArgumentOutOfRangeException(String.Format("{0} is less than absolute zero.", temperature));
            }
            this.temperature = temperature;
        }
        
        public decimal Celsius
        {
            get { return temperature; }
        }

        public decimal Fahrenheit
        {
            // Перевод Цельсия в Фарингейт.
            get { return temperature * 9 / 5 + 32; }
        }

        public decimal Kelvin
        {
            // Перевод Цельсия в Кельвин.
            get { return temperature + 273.15m; }
        }

        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        // Реализация IFormattable.
        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format))
                format = "G";

            if (provider == null)
                provider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "G":
                case "C":
                    return temperature.ToString("F2", provider) + " °C"; // F2 - формат вывода вещественного числа (2 знака после запятой).
                case "F":
                    return Fahrenheit.ToString("F2", provider) + " °F";
                case "K":
                    return Kelvin.ToString("F2", provider) + " K";
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var temperature = new Temperature(12); // 12°C

            Console.WriteLine("Temperature [default]     = {0}", temperature);
            Console.WriteLine("Temperature [Fahrenheit]  = {0:F}", temperature);
            Console.WriteLine("Temperature [CultureInfo] = {0}", temperature.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Temperature [CultureInfo] = {0}", temperature.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU")));

            // Delay.
            Console.ReadKey();
        }
    }
}