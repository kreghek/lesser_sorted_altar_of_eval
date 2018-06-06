using System.Collections;
using NUnit.Framework;

namespace Tests.Fibonacci.TestCaseDataSources
{
    internal class ModFibonacciTestCaseDataSource
    {
        public static IEnumerable TestCases()
        {
            yield return new TestCaseData(0, 3).Returns(0);
            yield return new TestCaseData(35, 3).Returns(2);
            yield return new TestCaseData(35, 101).Returns(4);
            yield return new TestCaseData(10_000, 1000).Returns(875);
            yield return new TestCaseData(10, 2).Returns(1);
        }
        
        public static IEnumerable TestCases_100_000()
        {
            yield return new TestCaseData(0).Returns(0);
            yield return new TestCaseData(1).Returns(1);
            yield return new TestCaseData(2).Returns(1);
            yield return new TestCaseData(3).Returns(2);
            yield return new TestCaseData(40).Returns(34_155);
            yield return new TestCaseData(10).Returns(55);
            yield return new TestCaseData(15).Returns(610);
            yield return new TestCaseData(25).Returns(75_025);
        }
    }
}
