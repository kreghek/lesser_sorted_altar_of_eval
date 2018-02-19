using Algo;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GreedActivitySelectorTests
    {
        /// <summary>
        /// 1. В системе есть массив из со случайными уникальными значениями.
        /// 2. Разделяем массив.
        /// 3. На новом массиве удовлетворяется условие разбиения.
        /// </summary>
        [Test]
        public void Execute_AnyActivities_ActivitiesAreNotIntersected()
        {
            //ARRANGE


            var s = new[] { 1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12 };  // пример из книги
            var f = new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };  // пример из книги


            // ACT

            var iList = GreedActivitySelector.Execute(s, f);



            //ASSERT

            // проверяем, что заявки не пересекаются.
            for (var i = 0; i < iList.Length; i++)
            {
                for (var j = 0; j < iList.Length; j++)
                {
                    if (i == j)
                        continue;

                    var si = s[i];
                    var fi = f[i];
                    var sj = s[j];
                    var fj = f[j];

                    var startInside = sj >= si && fj <= si;
                    var finishInside = sj >= fi && fj <= fi;

                    Assert.IsFalse(startInside);
                    Assert.IsFalse(finishInside);
                }
            }
        }

    }
}
