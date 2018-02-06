using System;

namespace Algo
{
    static class DataGenerator
    {
        private static Random random = new Random();

        public static int[] CreateFullRandom(int n)
        {
            var source = new int[n];

            for (var i = 0; i < n; i++)
            {
                source[i] = random.Next(1, n);
            }

            return source;
        }
    }
}
