using System;

namespace EnumType
{
    enum EnumType : byte
    {
        Zero,
        One=1,
        one=One,
        Two=2,
        Three,
        Four=4,
        Five=5,
        Seven=Nine,
        Eight=8,
        Nine=9,
        Infinite=255,
               
    }
    class Program
    {
        static void Main(string[] args)
        {
            EnumType x = EnumType.Five;
            EnumType y = EnumType.Four;

            Array array = Enum.GetValues(typeof(EnumType));
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}   {0:D} ", array.GetValue(i));
            }
            if (x>y)
                Console.WriteLine("x>y");
            else
                Console.WriteLine("x<=y");
        }
    }
}
