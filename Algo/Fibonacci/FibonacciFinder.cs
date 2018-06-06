using System;
using System.Collections.Generic;

namespace Algo.Fibonacci
{
    public static class FibonacciFinder
    {
        /// <summary>
        /// Вычисляет малые числа Фибоначчи. До n = 40.
        /// </summary>
        /// <param name="n">Номер числа Фибоначчи.</param>
        /// <returns>Возвращает число n-ое Фибоначчи. Если n > 40, то будет выбрашено исключение.</returns>
        public static int FindSmall(int n)
        {
            if (n > 40)
            {
                throw new ArgumentException("Данный метод ищет только первые 40 чисел Фибоначчи. n не болжно быть больше 40.", nameof(n));
            }

            var f1 = 0;
            var f2 = 1;

            switch (n)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
            }

            for (var i = 2; i <= n; i++)
            {
                var result = f1 + f2;
                f1 = f2;
                f2 = result;
            }

            return f2;
        }

        /// <summary>
        /// Вычисляет n-ое число Фибоначчи, обрезая его начало до указанного значения.
        /// </summary>
        /// <param name="n"> Номер числа. </param>
        /// <param name="m"> Модуль, по которому число обрезается. </param>
        /// <returns></returns>
        public static long FindMod(long n, long m)
        {
            var picanoList = CalcPicanoPeriod(m);
            var picano = picanoList.Count - 2;
            var moddedIndex = (int)(n % picano);
            return picanoList[moddedIndex];
        }

        private static List<long> CalcPicanoPeriod(long m)
        {
            var list = new List<long> {0, 1};
            
            for (var i = 2; i < m * 6; i++)
            {
                var f1 = list[i - 2];
                var f2 = list[i - 1];
                var next = (f1 + f2) % m;
                list.Add(next);

                if (f2 == 0 && next == 1)
                {
                    return list;
                }
            }

            return list;
        }
    }
}
