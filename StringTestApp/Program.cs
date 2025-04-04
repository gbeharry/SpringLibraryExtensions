using System;
using StringExtensionsLibrary;

namespace StringTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testStrings = { "Hello", "world", "", "123abc", "AnotherTest" };

            foreach (var str in testStrings)
            {
                Console.WriteLine($"'{str}' starts with uppercase? {str.StartsWithUpperCase()}");
            }
        }
    }
}
