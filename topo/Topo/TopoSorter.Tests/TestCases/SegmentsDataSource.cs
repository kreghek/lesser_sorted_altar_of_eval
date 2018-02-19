using System.Collections;
using Geom;
using NUnit.Framework;

namespace TopoSorter.Tests
{
    public class SegmentsDataSource
    {
        public static IEnumerable TestCases
        {
            get
            {
                // Еиничные перпендикулярные отрезки.
                // Пересекаются.
                yield return new TestCaseData(new Segment(0, 0, 1, 1), new Segment(0, 1, 1, 0)).Returns(true);

                // Единичные параллельные отрезки.
                // Не пересекаются.
                yield return new TestCaseData(new Segment(0, 0, 1, 1), new Segment(0, 2, 1, 3)).Returns(false);

                // Не параллельные отрезки.
                // Не пересекаются.
                yield return new TestCaseData(new Segment(0, 0, 1, 1), new Segment(0, 2, 3, 3)).Returns(false);

                // Одинаковые отрезки.
                // Пересекаются.
                yield return new TestCaseData(new Segment(0, 0, 1, 1), new Segment(0, 0, 1, 1)).Returns(true);

                // Один из отрезков - точка на другом отрезке. Находится в начале.
                // Пересекаются.
                yield return new TestCaseData(new Segment(0, 0, 0, 0), new Segment(0, 0, 1, 1)).Returns(true);

                // Один из отрезков - точка на другом отрезке. Находится в конце.
                // Пересекаются.
                yield return new TestCaseData(new Segment(1, 1, 1, 1), new Segment(0, 0, 1, 1)).Returns(true);

                // Один из отрезков - точка на другом отрезке. Находится внутри.
                // Пересекаются.
                yield return new TestCaseData(new Segment(1, 1, 1, 1), new Segment(0, 0, 2, 2)).Returns(true);

                // Один из отрезков - точка за пределами на другого отрезка.
                // Не пересекаются.
                yield return new TestCaseData(new Segment(3, 3, 3, 3), new Segment(0, 0, 1, 1)).Returns(false);

                // Оба отрезка - разные точки.
                // Не пересекаются.
                yield return new TestCaseData(new Segment(3, 3, 3, 3), new Segment(1, 1, 1, 1)).Returns(false);

                // Еиничные перпендикулярные отрезки вдоль осей.
                // Пересекаются.
                yield return new TestCaseData(new Segment(0, 1, 0, -1), new Segment(-1, 0, 1, 0)).Returns(true);

                // два отрезка на одной прямой, но в разных местах.
                // Не пересекаются.
                yield return new TestCaseData(new Segment(0, 1, 0, -1), new Segment(0, 3, 0, 8)).Returns(false);
            }

        }
    }
}
