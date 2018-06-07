using Algo.Cgd;
using NUnit.Framework;
using Tests.Gcd.TestCaseDataSources;

namespace Tests.Gcd
{
    [TestFixture]
    public class GcdFinderTests
    {
        [Test]
        [TestCaseSource(typeof(GcdTestCaseDataSource),
            nameof(GcdTestCaseDataSource.TestCases))]
        [Timeout(2000)]
        public long Euclid_AnyNumbers_CorrectResults(long a, long b)
        {
            // ARRANGE
            
            
            
            // ACT
            var d = GcdFinder.Euclid(a, b);


            // ASSERT
            return d;
        }
    }
}