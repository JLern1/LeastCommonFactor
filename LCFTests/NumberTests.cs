using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LCFBusiness;

namespace LCFTests
{
    [TestFixture]
    class NumberTests
    {

        Checker _checker = new Checker();


        [Test]
        [TestCase(55, 95, 5)]
        [TestCase(22, 11, 11)]
        [TestCase(7, 21, 7)]
        [TestCase(25, 50, 5)]
        [TestCase(25, 50, 6)]
        public void TestNumbers(int firstNum, int secondNum, int expected)
        {                

            var actual = _checker.CheckValues(firstNum, secondNum);
            Assert.AreEqual(expected, actual);
           
        }


        [Test]
        [TestCase(22, 11, 11, ExpectedResult = true)]
        [TestCase(22, 11, 9, ExpectedResult = true)]
        [TestCase(22, 11, 3, ExpectedResult = true)]
        [TestCase(22, 11, 22, ExpectedResult = true)]
        [TestCase(22, 11, 17, ExpectedResult = true)]
        [TestCase(22, 11, 11, ExpectedResult = true)]
        public bool AreBothDivisibleTester(int firstNum, int secondNum, int divisor)
        {
            return _checker.AreBothDivisible(firstNum, secondNum, divisor);
        }
    }
}
