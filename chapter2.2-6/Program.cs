using System;
using System.Collections.Generic;
using System.Globalization;

namespace chapter2._2_6
{
    class Program
    {
        static void Main(string[] args)
        {
           PrintItems<string>(List<string> ,CultureInfo.InvariantCulture) ;//不知道主函数怎么写
        }
        static void PrintItems<T>(List<T> items) where T : IFormattable
        {
              CultureInfo culture = CultureInfo.InvariantCulture;
              foreach (T item in items)
            {
                Console.WriteLine(item.ToString(null, culture));
            }
        }
    }
}
