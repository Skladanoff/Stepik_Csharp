using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace SimpleArray
{
    [TestFixture]
    public class Test 
    {
        //[Test]  // <= так нужно пометить метод, чтобы система тестирования поняла, что это тест.
        //public void SingleTest()
        //{
        //    //Assert.AreEqual(2, MyClass.MySuperMethod(1, 1));
        //}

        //[TestCase("1 2 3 4 5", 9)]
        //[TestCase("5 4 3 2 1", 9)]
        //[TestCase("4 3 1 2 5", 2)]
        //[TestCase("4 3 5 2 1", 2)]
        //[TestCase("1", 0)]
        //[TestCase("", 0)]

        //public void TestCasesSumOfElementsBetweenMinAndMax(string a, int expectedResult)
        //{
        //    Assert.AreEqual(expectedResult, Program.SumOfElementsBetweenMinAndMax(a));
        //}

        //[TestCase("0 0 1 1 0 1 1 1 0 1", 3)]
        //[TestCase("0 1 1 0 1", 2)]
        //[TestCase("1 1 1 1 0", 4)]
        //[TestCase("4 3 5 2 1", 1)]
        //[TestCase("1", 1)]


        //public void TestCasesSumSequenceUnits(string a, int expectedResult)
        //{
        //    Assert.AreEqual(expectedResult, Program.SumSequenceUnits(a));
        //}

        //[TestCase("1 0 2 0 3", "1 2 3 0 0 ")]
        //[TestCase("0 0 1 2 3", "1 2 3 0 0 ")]
        //[TestCase("6 0 2 1 0 7 5 0", "6 2 1 7 5 0 0 0 ")]
        //[TestCase("6 0 2 1 0 7 5 0 8 9 0 5 3 6 8", "6 2 1 7 5 8 9 5 3 6 8 0 0 0 0 ")]
        //[TestCase("1 2 3 4 0", "1 2 3 4 0 ")]
        //[TestCase("0 10 0 30 20 0", "10 30 20 0 0 0 ")]
        //public void TestCasesRemoveZeroesToEnd(string a, string expectedResult)
        //{
        //    Assert.AreEqual(expectedResult, Program.RemoveZeroesToEnd(a));
        //}


        [TestCase("1 2 3 2 1", "YES")]
        [TestCase("0 1 2 3 4", "NO")]
        [TestCase("4 3 2 1 0", "NO")]
        [TestCase("1 5 4 3 2 1", "YES")]
        [TestCase("0 1 2 3 4 3", "YES")]
        [TestCase("0 0 0 0 0", "NO")]
        [TestCase("1 100 1", "YES")]
        [TestCase("-1 0 2 0 -2", "YES")]
        [TestCase("1 -1 -2 0 1", "NO")]
        [TestCase("0 1 2 3 3 4 3", "NO")]
        [TestCase("0 1 2 3 4 3 4", "NO")]

        public void TestCasesBeautifulMountai(string a, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Program.BeautifulMountain(a));
        }
    }
}
