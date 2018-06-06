using System;
using FluentAssertions;
using NUnit.Framework;
using Tests.Fibonacci.TestCaseDataSources;

namespace Algo.Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciFinderTests
    {

        [Test]
        [TestCaseSource(typeof(SmallFibonacciTestCaseDataSource),
            nameof(SmallFibonacciTestCaseDataSource.TestCases))]
        public int FindSmall_ConnectN_CorrectResult(int n)
        {
            // ARRANGE
            



            // ACT
            var f = FibonacciFinder.FindSmall(n);



            // ASSERT
            return f;
        }

        [Test]
        [TestCaseSource(typeof(SmallFibonacciTestCaseDataSource),
            nameof(SmallFibonacciTestCaseDataSource.TestCasesTooBig))]
        public void FindSmall_NMoreThat40_ArgumentException(int n)
        {
            // ARRANGE



            // ACT
            Action act = () =>
            {
                var f = FibonacciFinder.FindSmall(n);
                Console.WriteLine(f);
            };


            // ASSERT
            act.Should().Throw<ArgumentException>();
        }
        
        [Test]
        [TestCaseSource(typeof(ModFibonacciTestCaseDataSource),
            nameof(ModFibonacciTestCaseDataSource.TestCases_100_000))]
        public int FindMod_TestOnSmallAndFixedMod_CorrectResult(int n)
        {
            // ARRANGE
            const long m = 100_000L;



            // ACT
            var f = FibonacciFinder.FindMod(n, m);



            // ASSERT
            return (int)f;
        }
        
        [Test]
        [TestCaseSource(typeof(ModFibonacciTestCaseDataSource),
            nameof(ModFibonacciTestCaseDataSource.TestCases))]
        public long FindMod_BigNumbersAndDifferentMods_CorrectResult(int n, long m)
        {
            // ARRANGE
            



            // ACT
            var f = FibonacciFinder.FindMod(n, m);



            // ASSERT
            return f;
        }
    }
}