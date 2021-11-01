using Homework3;
using NUnit.Framework;

namespace Homework3Tests
{
    public class HW3Tests
    {
        private HW3 _hw3;
        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();
        }

        [TestCase(300,"  300\t 600\t 900\t")]
        public void PrintNumbersDividedByUserNumberTest(int a, string expected )
        {
            //arrange
            //act
            string actual = _hw3.PrintNumbersDividedByUserNumber(a);
            //assert 
            Assert.AreEqual(expected,actual);
        }
        /*[TestCase("24", 24)]
        public void GetNumberFromUser(string a, int expected)
        {
            //arrange
            //act
            int actual = _hw3.GetNumberFromUser(a);
            //assert
            Assert.AreEqual(expected, actual);
        }*/
        [TestCase(2,3,8)]
        public void ExponentiateUserNumberInAPositiveExponentTest(int a,int b, int expected)
        {
            //arrange
            //act
            int actual = _hw3.ExponentiateUserNumberInAPositiveExponent(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, -2, 0.25)]
        public void ExponentiateUserNumberInANegativeExponentTest(int a, int b, double expected)
        {
            //arrange
            //act
            double actual = _hw3.ExponentiateUserNumberInANegativeExponent(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2,3,"8")]
        [TestCase(25,-2,"0,0016")]
        [TestCase(2,0,"1")]
        public void ExponentiateUserNumberTest(int a, int b, string expected)
        {
            //arrange
            //act
            string actual = _hw3.ExponentiateUserNumber(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(25,4)]
        [TestCase(120, 10)]
        [TestCase(0, 0)]
        public void FindPositiveIntTest(int a, int expected)
        {
            //arrange
            //act
            int actual = _hw3.FindPositiveInt(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(16,8)]
        [TestCase(25, 5)]
        [TestCase(90, 45)]
        public void FindTheGreatestDivisor(int a, int expected)
        {
            //arrange
            //act
            int actual = _hw3.FindTheGreatestDivisor(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3,29,70)]
        public void CalcSumFromRangeTest(int a, int b, int expected)
        {
            //arrange
            //act
            int actual = _hw3.CalcSumFromRange(a, b);
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(8,1,1,0,21)]
        public void CycleForFibanacciNumberTest(int n, int prev1, int prev2, int sum, int expected)
        {
            //arrange
            //act
            int actual = _hw3.CycleForFibanacciNumber(n, prev1, prev2, sum);
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(7,13)]
        [TestCase(1, 1)]
        public void PrintFibonacciNumberTest(int n,int expected)
        {
            //arrange
            //act
            int actual = _hw3.PrintFibonacciNumber(n);
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(54,81,27)]
        [TestCase(1,1,1)]
        [TestCase(21,63,21)]
        public void FindTheGreatestCommonDivisorTest(int a, int b, int expected)
        {
            //arrange
            //act
            int actual = _hw3.FindTheGreatestCommonDivisor(a, b);
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(90, 4.4817352294921875d)]
        [TestCase(125, 5.0001144409179688d)]
        public void SearchSquareTest(double number,double expected)
        {
            //arrange
            //act
            double actual = _hw3.SearchSquare(number);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(15,8)]
        [TestCase(-5,3)]
        [TestCase(45,23)]
        public void CountOddNumbersInUserInputTest(int userInput, int expected)
        {
            //arrange
            //act
            int actual = _hw3.CountOddNumbersInUserInput(userInput);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(111,111)]
        [TestCase(345,543)]
        [TestCase(6578,8756)]
        public void PrintTheMirroredNumber(int a, int expected)
        {
            //arrange
            //act
            int actual = _hw3.PrintTheMirroredNumber(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(45, "2 4 6 8 12 14 16 18 20 21 22 24 26 28 34 36 38 40 41 42 43 44 ")]
        [TestCase(13, "2 4 6 8 12 ")]
        [TestCase(7, "2 4 6 ")]
        public void CountOddNumbersInInputTest(int a,string expected)
        {
            //arrange
            //act
            string actual = _hw3.CountOddNumbersInInput(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25,565, "Yeees")]
        [TestCase(546,789, "Soory,bro, maybe next time")]
        public void FindTheSameNumbers(int a, int b, string expected)
        {
            //arrange
            //act
            string actual = _hw3.FindTheSameNumbers(a,b);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}