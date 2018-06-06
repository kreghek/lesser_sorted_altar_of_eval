using System;
using Algo.Fibonacci;

namespace Lesson2_Hard
{
    class Program
    {
        static void Main()
        {
            var inputStr = Console.ReadLine();
            if (inputStr == null)
            {
                return;
            }
            
            var inputParts = inputStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var n = Convert.ToInt64(inputParts[0]);
            var m = Convert.ToInt64(inputParts[1]);

            var f = FibonacciFinder.FindMod(n, m);
            
            Console.Write(f);
        }
    }
}