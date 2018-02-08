using System;
using Algo.Sorters;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class QuickSorterTests
    {
        /// <summary>
        /// 1. В системе есть массив из со случайными уникальными значениями.
        /// 2. Разделяем массив.
        /// 3. На новом массиве удовлетворяется условие разбиения.
        /// </summary>
        [Test]
        public void Partition_HasRandomUniqueArray_ReturnsValidPartitionValue()
        {
            //ARRANGE

            var sorter = new QuickSorter();
            var a = new[] { 2, 8, 7, 1, 3, 5, 6, 4 };  // пример из книги


            // ACT

            var q = sorter.Partition(a, 0, a.Length - 1);



            //ASSERT

            var expectedQ = 3 - 1; // 3 элемент будет опорным, но q указывает на клайний элемент группы.
            Assert.AreEqual(expectedQ, q);
            AssertPartition(a, q);
        }


        /// <summary>
        /// 1. В системе есть массив из со случайными уникальными значениями.
        /// 2. Сортируем.
        /// 3. Массив отсортирован.
        /// </summary>
        [Test]
        public void Sort_SortRandomUniqueArray_ReturnsSortedArray()
        {
            //ARRANGE

            var sorter = new QuickSorter();
            var a = new[] { 6, 1, 3, 4, 9, 2 };


            // ACT

            sorter.Sort(a);



            //ASSERT

            AssertHelper.ArrayIsSorted(a);
        }


        /// <summary>
        /// Проверка условия разбиения:
        /// - все элементы до опорного - меньше или равны.
        /// - все элементы после опорного - больше или равны.
        /// </summary>
        /// <param name="a">Массив</param>
        /// <param name="q">Индекс опорного элемента.</param>
        private static void AssertPartition(int[] a, int q)
        {
            var qValue = a[q + 1];

            for (var i = 0; i <= q - 1; i++)
            {
                Assert.LessOrEqual(a[i], qValue);
            }

            for (var i = q + 1; i < a.Length; i++)
            {
                Assert.GreaterOrEqual(a[i], qValue);
            }
        }
    }
}
