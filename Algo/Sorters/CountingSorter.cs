namespace Algo.Sorters
{
    public class CountingSorter : ISorter
    {
        private readonly int k;

        public CountingSorter(int maxValue)
        {
            k = maxValue;
        }

        public int[] Sort(int[] source)
        {
            var b = new int[source.Length];
            var c = new int[k + 1];

            for (var i = 0; i < source.Length; i++)
            {
                var sourceValue = GetSortValue(source[i]);
                c[sourceValue]++;
            }

            for (var i = 1; i <= k; i++)
            {
                c[i] += c[i - 1];
            }

            for (var j = source.Length - 1; j >= 0; j--)
            {
                b[c[source[j]]-1] = source[j];
                c[source[j]]--;
            }

            return b;
        }

        protected virtual int GetSortValue(int sourceValue)
        {
            return sourceValue;
        }
    }
}
