using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geom;
using NUnit.Framework;

namespace TopoSorter.Tests
{
    [TestFixture]
    class SegmentHelperTests
    {
        /// <summary>
        /// 1. В системе есть два отрезка. Отрезки могут пересекаться или нет. Могут быть вырожденные случаи.
        /// 2. Выполняем проверку.
        /// 3. Пересечение в зависимости от тест-кейса.
        /// </summary>
        [Test]
        [TestCaseSource(typeof(SegmentsDataSource), "TestCases")]
        public bool Intersect_AnyIntersectingSegments_ReturnsTrue(Segment s1, Segment s2) {
            return SegmentHelper.Intersect(s1, s2);
        }
    }
}
