using System.Collections;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace Tests.Gcd.TestCaseDataSources
{
    [SuppressMessage("ReSharper", "HeapView.ObjectAllocation.Evident")]
    [SuppressMessage("ReSharper", "HeapView.BoxingAllocation")]
    internal class GcdTestCaseDataSource
    {
        public static IEnumerable TestCases()
        {
            yield return new TestCaseData(12, 16).Returns(4);
            yield return new TestCaseData(16, 12).Returns(4);
            yield return new TestCaseData(7, 3).Returns(1);
            
            // Stepik
            yield return new TestCaseData(18, 35).Returns(1);
            yield return new TestCaseData(14_159_572, 6_3967_072).Returns(4);
        }
    }
}