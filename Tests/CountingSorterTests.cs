using Algo.Sorters;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CountingSorterTests
    {
        /// <summary>
        /// 1. В системе есть массив из со случайными уникальными значениями.
        /// 2. Сортируем.
        /// 3. Массив отсортирован.
        /// </summary>
        [Test]
        public void Sort_SortRandomUniqueArray_ReturnsSortedArray()
        {
            //ARRANGE

            var sorter = new CountingSorter(10);
            var a = new[] { 6, 1, 3, 4, 9, 2 };


            // ACT

            var resultA = sorter.Sort(a);



            //ASSERT

            AssertHelper.ArrayIsSorted(resultA);
        }
    }
}
