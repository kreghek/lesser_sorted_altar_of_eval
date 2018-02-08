using Algo.Sorters;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MergeSorterTests
    {
        /// <summary>
        /// 1. В системе есть массив, где две группы элементов, p..q и q+1..r, отсортированы.
        /// 2. Мержим массивы от элемента q.
        /// 3. Получаем результирующий массив p..q с отсортированными элементами.
        /// </summary>
        [Test]
        public void Merge_MergeTwoArrays_ReturnsArrayWithAllElements()
        {
            //ARRANGE

            var sorter = new MergeSorter();
            var a = new[] { 2, 3, 6, 1, 4, 5 };
            var p = 0;
            var q = 2;
            var r = 5;



            // ACT

            sorter.Merge(a, p, q, r);



            //ASSERT

            AssertHelper.ArrayIsSorted(a);
        }

        /// <summary>
        /// 1. В системе есть произвольный массив.
        /// 2. Сортируем массив.
        /// 3. На выходе получаем отсортированный массив.
        /// </summary>
        [Test]
        [TestCaseSource(typeof(ArrayTestCaseData), nameof(ArrayTestCaseData.TestCases))]
        public void Sort_FromArrayTestCases_ReturnsSortedArray(int[] a)
        {
            //ARRANGE

            var sorter = new MergeSorter();



            // ACT

            sorter.Sort(a);



            //ASSERT

            AssertHelper.ArrayIsSorted(a);
        }

        ///// <summary>
        ///// 1. В системе есть массив из одного элемента.
        ///// 2. Сортируем массив.
        ///// 3. На выходе получаем массив из одного элемента.
        ///// </summary>
        //[Test]
        //public void Sort_HasOneElementArray_ReturnsSortedArray()
        //{
        //    //ARRANGE

        //    var sorter = new MergeSorter();
        //    var a = new[] { 2 };



        //    // ACT

        //    sorter.Sort(a);



        //    //ASSERT

        //    AssertHelper.ArrayIsSorted(a);
        //}

        ///// <summary>
        ///// 1. В системе есть массив из нечётного количества элементов.
        ///// 2. Сортируем массив.
        ///// 3. На выходе получаем отсортированный массив.
        ///// </summary>
        //[Test]
        //public void Sort_OddArray_ReturnsSortedArray()
        //{
        //    //ARRANGE

        //    var sorter = new MergeSorter();
        //    var a = new[] { 2, 3, 1 };



        //    // ACT

        //    sorter.Sort(a);



        //    //ASSERT

        //    AssertHelper.ArrayIsSorted(a);
        //}
    }
}
