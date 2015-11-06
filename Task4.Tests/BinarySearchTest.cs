using System;
using System.Collections.Generic;
using System.Linq;
using Task4;
using NUnit.Framework;

namespace Task4.Tests
{
    [TestFixture]
    public class BinarySearchTest
    {
        private readonly int[] array = new[] {-4, 0, 2, 3, 7, 8, 10};

        public IEnumerable<TestCaseData> TestDatas
        {
            get
            {
                yield return new TestCaseData(-1).Returns(-1);
                yield return new TestCaseData(-4).Returns(0);
                yield return new TestCaseData(0).Returns(1);
                yield return new TestCaseData(15).Returns(-1);
                yield return new TestCaseData(9).Returns(-1);
                yield return new TestCaseData(7).Returns(4);
            }
        }

        [Test, TestCaseSource(nameof(TestDatas))]
        public int BinarySearchMethod_Test(IComparable element)
        {
            return array.BinarySearch(element);
        }
    }
}
