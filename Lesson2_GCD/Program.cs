using System;
using Algo.Cgd;

namespace Lesson2_GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine();
            if (inputStr == null)
            {
                return;
            }
            
            var inputParts = inputStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var a = Convert.ToInt64(inputParts[0]);
            var b = Convert.ToInt64(inputParts[1]);

            var d = GcdFinder.Euclid(a, b);
            
            Console.Write(d);
        }
    }
}