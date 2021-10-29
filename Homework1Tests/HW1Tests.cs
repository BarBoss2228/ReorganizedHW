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
        /*[TestCase()]
        public void SwapNumbers(ref int a, ref int b)
        {

        }*/
        [TestCase(2,4,8,2)]
        public void SolveLinearEquation(int a,int b, int c, int expected)
        {
            //arrange
            //act
            int actual = _hw1.SolveLinearEquation(a,b,c);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,2,1,1,1)]
        public void CalculateFactorK(int x1, int y1, int x2, int y2, int expected)
        {
            //arrange
            //act
            int actual = _hw1.CalculateFactorK(x1, y1, x2, y2);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,2,6,2)]
        public void CalculateFactorB(int k, int x2, int y2, int expected)
        {
            //arrange
            //act
            int actual = _hw1.CalculateFactorB(k, x2, y2);
            //assert
            Assert.AreEqual(expected, actual);
        }


    }
}