using System.Collections;
using System.Linq;
using Algo;
using NUnit.Framework;

namespace Tests
{
    class ArrayTestCaseData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 6, 1, 3, 4, 9, 2 })
//                    .("Random Unique Values")
                    .SetDescription("Случайные уникальные значения.");

                yield return new TestCaseData(new[] { 6 })
                 //   .SetName("Only one value")
                    .SetDescription("Набор из одного элемента.");

                yield return new TestCaseData(new[] { 8, 6, 1, 3, 4, 9, 2, 5, 7, 0 })
                 //   .SetName("Odd count")
                    .SetDescription("Чётное коичество элементов.");

                yield return new TestCaseData(new[] { 8, 6, 1, 4, 9, 2, 5, 7, 0 })
                   // .SetName("Even count")
                    .SetDescription("Не Чётное коичество элементов.");

                yield return new TestCaseData(new[] { 5, 6, 1, 4, 4, 2, 5, 7, 0, 0 })
                    //.SetName("Has dublicates")
                    .SetDescription("Наличие дубликатов.");

                yield return new TestCaseData(new[] { 8, 8, 8 })
                    //.SetName("Only dublicates")
                    .SetDescription("Только дубликаты.");

                yield return new TestCaseData(Enumerable.Range(1, 10).ToArray())
                    //.SetName("Ordered array")
                    .SetDescription("Уже упорядоченный набор.");

                yield return new TestCaseData(Enumerable.Range(1, 10).Reverse().ToArray())
                    //.SetName("Ordered desc array")
                    .SetDescription("Упорядоченный по убыванию набор.");

                yield return new TestCaseData(Enumerable.Range(1, 1_000).ToArray().SuffleMod(33, 17))
                    //.SetName("1K")
                    .SetDescription("Большой набор. 1K элментов.");

                yield return new TestCaseData(Enumerable.Range(1, 1_000_000).ToArray().SuffleMod(33, 17))
                    //.SetName("1M")
                    .SetDescription("Большой набор. 1M элементов.");
            }
        }
    }

    public static class TestCaseDataExtension
    {

        public static int[] SuffleMod(this int[] a, int mod, int q = 1)
        {
            for (var i = 0; i < a.Length; i++)
            {
                var x = a[i] * q;
                var rnd = x % mod;

                SortHelper.Exchange(a, i, rnd);
            }

            return a;
        }
    }
}
