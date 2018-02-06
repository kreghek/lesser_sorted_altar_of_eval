namespace Algo.Sorters
{
    public class InsertSorter : ISorter
    {
        public int[] Sort(int[] source)
        {
            for (var i = 1; i < source.Length; i++)
            {
                var key = source[i];

                var j = i - 1;
                while (j > -1 && source[j] > key)
                {
                    source[j + 1] = source[j];
                    j--;
                }

                source[j + 1] = key;
            }

            return source;
        }
    }
}
