using Algo.Sorters;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class RandomQuickSorterTests
    {
        /// <summary>
        /// 1. В системе есть произвольный массив.
        /// 2. Сортируем.
        /// 3. Массив отсортирован.
        /// </summary>
        [Test]
        [TestCaseSource(typeof(ArrayTestCaseData), nameof(ArrayTestCaseData.TestCases))]
        public void Sort_SortRandomUniqueArray_ReturnsSortedArray(int[] a)
        {
            //ARRANGE

            var sorter = new RandomQuickSorter();



            // ACT

            sorter.Sort(a);



            //ASSERT

            AssertHelper.ArrayIsSorted(a);
        }
    }
}
