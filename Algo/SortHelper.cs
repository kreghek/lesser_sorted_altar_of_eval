namespace Algo
{
    public static class SortHelper
    {
        public static void Exchange(int[] a, int x, int y)
        {
            var temp = a[x];
            a[x] = a[y];
            a[y] = temp;
        }
    }
}
