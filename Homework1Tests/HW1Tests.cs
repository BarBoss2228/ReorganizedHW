using Homework1;
using NUnit.Framework;

namespace Homework1Tests
{
    public class HW1Tests
    {
        private HW1 _hw1;
        [SetUp]
        public void Setup()
        {
            _hw1 = new HW1();
        }

        [TestCase(1,2,9)]
        public void CalcFormula(int a, int b, double expected)
        {
            //arrange
            //act
            double actual = _hw1.CalcFormula(a, b);
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}