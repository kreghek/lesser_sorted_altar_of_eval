using System.Collections;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace Tests.Fibonacci.TestCaseDataSources
{
    [SuppressMessage("ReSharper", "HeapView.ObjectAllocation.Evident")]
    [SuppressMessage("ReSharper", "HeapView.BoxingAllocation")]
    internal class SmallFibonacciTestCaseDataSource
    {
        public static IEnumerable TestCases()
        {
            yield return new TestCaseData(0).Returns(0);
            yield return new TestCaseData(1).Returns(1);
            yield return new TestCaseData(2).Returns(1);
            yield return new TestCaseData(3).Returns(2);
            yield return new TestCaseData(40).Returns(102_334_155);
            yield return new TestCaseData(10).Returns(55);
            yield return new TestCaseData(15).Returns(610);
            yield return new TestCaseData(25).Returns(75_025);
        }

        public static IEnumerable TestCasesTooBig()
        {
            yield return new TestCaseData(41);
            yield return new TestCaseData(141);
            yield return new TestCaseData(100000);
        }
    }
}
