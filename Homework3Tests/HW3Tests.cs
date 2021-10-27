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
    }
}