namespace Algo.Sorters
{
    public class InsertSorter : ISorter
    {
        public int[] Sort(int[] source)
        {
            for (var j = 1; j < source.Length; j++)
            {
                var key = source[j];

                var i = j - 1;
                while (i > -1 && source[i] > key)
                {
                    source[i + 1] = source[i];
                    i--;
                }

                source[i + 1] = key;
            }

            return source;
        }
    }
}
