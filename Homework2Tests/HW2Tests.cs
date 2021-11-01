using Homework2;
using NUnit.Framework;

namespace Homework2Tests
{
    public class HW2Tests
    {
        private HW2 _hw2;
        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }

        [TestCase(6, 3, 9)]
        public void CalcResult(int a, int b, int expected)
        {
            //arrange
            //act
            int actual = _hw2.CalcResult(a, b);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(6, 3, 4, "3 4 6")]
        public void PrintNumbersInAscendingOrder(int a, int b, int c, string expected)
        {
            //arrange
            //act
            string actual = _hw2.PrintNumbersInAscendingOrder(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, -5, 6, new double[] { 2, 3 })]
        public void SolveQuadraticEquation(int a, int b, int c, double[] expected)
        {
            //arrange
            //act
            double[] actual = _hw2.SolveQuadraticEquation(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new double[] { 1 }, "1 ")]
        public void AnalyzeArrayLengthTest(double[] result, string expected)
        {
            //arrange
            //act
            string actual = _hw2.AnalyzeArrayLength(result);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25,"Двадцать пять")] // как в тесте прописать ошибку
        
        public void SwitchNumbersToWordsTest(int a, string expected)
        {
            //arrange
            //act
            string actual = _hw2.SwitchNumbersToWords(a);
            //assert
            Assert.AreEqual(expected, actual);
        }



    }
}