using System.Collections.Generic;

namespace Algo
{
    public static class GreedActivitySelector
    {
        public static int[] Execute(int[] s, int[] f)
        {
            var result = new List<int>();

            result.Add(0);
            var j = 0;

            for (var i = 2; i < s.Length; i++)
            {
                if (s[i] >= f[j])
                {
                    result.Add(i);
                    j = i;
                }
            }

            return result.ToArray();
        }
    }
}
