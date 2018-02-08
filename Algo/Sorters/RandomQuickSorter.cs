using System;

namespace Algo.Sorters
{
    public class RandomQuickSorter : QuickSorter
    {
        private Random random = new Random();

        public override void QuickSort(int[] a, int p, int r)
        {
            if (p < r)
            {
                var q = Partition(a, p, r);
                QuickSort(a, p, q - 1);
                QuickSort(a, q + 1, r);
            }
        }

        public int RandomizedPartition(int[] a, int p, int r)
        {
            var i = random.Next(p, r);
            SortHelper.Exchange(a, i, r);
            return Partition(a, p, r);
        }
    }
}
