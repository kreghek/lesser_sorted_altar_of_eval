using System;

namespace Algo.Sorters
{
    public class MergeSorter : ISorter
    {
        public int[] Sort(int[] source)
        {
            SortInner(source, 0, source.Length - 1);
            return source;
        }

        public void Merge(int[] a, int p, int q, int r)
        {
            var n1 = q - p + 1;
            var n2 = r - q;
            var left = new int[n1 + 1];
            var right = new int[n2 + 1];

            for (var i = 0; i < n1; i++)
            {
                left[i] = a[p + i];
            }

            for (var i = 0; i < n2; i++)
            {
                right[i] = a[q + 1 + i];
            }

            left[n1] = int.MaxValue;
            right[n2] = int.MaxValue;

            var leftIdx = 0;
            var rightIdx = 0;

            for (var i = p; i <= r; i++)
            {
                if (left[leftIdx] <= right[rightIdx])
                {
                    a[i] = left[leftIdx];
                    leftIdx++;
                }
                else
                {
                    a[i] = right[rightIdx];
                    rightIdx++;
                }
            }
        }

        private void SortInner(int[] a, int p, int r)
        {
            if (p < r)
            {
                var q = (int)Math.Floor((float)(p + r) / 2);
                SortInner(a, p, q);
                SortInner(a, q + 1, r);
                Merge(a, p, q, r);
            }
        }
    }
}
