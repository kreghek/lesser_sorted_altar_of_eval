namespace Algo.Cgd
{
    /// <summary>
    /// Класс для поиска наибольшего общего делителя разными алгоритмами.
    /// </summary>
    public static class GcdFinder
    {
        /// <summary>
        /// Алгоритм Эвклида.
        /// </summary>
        /// <param name="a"> Первое число. </param>
        /// <param name="b"> Второе число. </param>
        /// <returns> Возвращает наибольший обзий делитель двух указанных чисел. </returns>
        public static long Euclid(long a, long b)
        {
            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if (a >= b)
            {
                return Euclid(a % b, b);
            }
            else
            {
                return Euclid(a, b % a);
            }
        }
    }
}