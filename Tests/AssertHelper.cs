using NUnit.Framework;

namespace Tests
{
    public static class AssertHelper
    {
        /// <summary>
        /// Проверка, что массив отсортирован по возрастанию.
        /// </summary>
        /// <param name="a">Тестируемый массив.</param>
        public static void ArrayIsSorted(int[] a)
        {
            for (var i = 1; i < a.Length; i++)
            {
                Assert.LessOrEqual(a[i - 1], a[i], $"Элемент i:{i - 1} ({a[i - 1]}) больше чем i:{i} ({a[i]}).");
            }
        }

        /// <summary>
        /// См формулу 7.1
        /// </summary>
        public static void ArrayIsHeap(int parent, int left, int right)
        {
            Assert.GreaterOrEqual(parent, left);
            Assert.GreaterOrEqual(parent, right);
        }
    }
}