namespace Algo.Sorters
{
    public class QuickSorter : ISorter
    {
        public int[] Sort(int[] source)
        {
            QuickSort(source, 0, source.Length - 1);
            return source;
        }

        public virtual void QuickSort(int[] a, int p, int r)
        {
            if (p < r)
            {
                var q = Partition(a, p, r);
                QuickSort(a, p, q - 1);
                QuickSort(a, q + 1, r);
            }
        }

        public int Partition(int[] a, int p, int r)
        {
            var x = a[r];
            var i = p - 1;

            for (var j = p; j < r; j++)
            {
                if (a[j] <= x)
                {
                    i++;
                    SortHelper.Exchange(a, i, j);
                }
            }
            SortHelper.Exchange(a, i + 1, r);

            return i;
        }
    }
}
