using System;

namespace Swap
{
    /*
     * функция Swap(string input), которая меняет местами первую и вторую половины строки (Swap("ABCD") -> "CDAB")
     */
    class Program
    {
        static void Main()
        {
            StringHelper helper = new StringHelper();
            string SomeString = Set();
            string final = helper.Swap(SomeString);
            Console.WriteLine(final);
        }

        private static string Set()
        {
            Console.WriteLine("Введите строку: ");
            string SomeString = Console.ReadLine();
            return SomeString;
        }
    }
}
