namespace Algo.Sorters
{
    public class HeapSorter : ISorter
    {
        public int[] Sort(int[] source)
        {
            var heap = new Heap
            {
                A = source,
                HeapSize = source.Length
            };
            HeapSort(heap);

            return source;
        }

        public void Heapify(Heap heap, int i)
        {
            var left = Left(i);
            var right = Right(i);
            var largest = 0;

            if (left <= heap.HeapSize - 1 && heap.A[left] > heap.A[i])
            {
                largest = left;
            }
            else
            {
                largest = i;
            }

            if (right <= heap.HeapSize - 1 && heap.A[right] > heap.A[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                SortHelper.Exchange(heap.A, i, largest);
                Heapify(heap, largest);
            }
        }

        public void BuildHeap(Heap heap)
        {
            heap.HeapSize = heap.A.Length;

            for (var i = heap.A.Length / 2; i >= 0; i--)
            {
                Heapify(heap, i);
            }
        }

        public void HeapSort(Heap heap)
        {
            BuildHeap(heap);
            for (var i = heap.A.Length - 1; i >= 1; i--)
            {
                SortHelper.Exchange(heap.A, 0, i);
                heap.HeapSize--;
                Heapify(heap, 0);
            }
        }

        public int Parent(int i)
        {
            return (i + 1) / 2;
        }

        public int Left(int i)
        {
            //TODO Можно заменить на операции левого и правого сдвига
            return 2 * (i + 1) - 1;
        }

        public int Right(int i)
        {
            return 2 * (i + 1);
        }
    }

    public class Heap
    {
        public int HeapSize { get; set; }
        public int[] A { get; set; }
    }
}
