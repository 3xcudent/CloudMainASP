using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
namespace CloudMainASP.Test
{
    public class CloudMainASPTest {

        private CloudMainASP _unitTesting = null;

        public CloudMainASPTest()
        {
            if (_unitTesting == null)
            {
                _unitTesting = new CloudMainASP();
            }
        }

        [Fact]
        public void IsAddWorks()
        {
            //arrange
            double a = 5;
            double b = 3;
            double expected = 8;

            //act
            var actual = _unitTesting.Add(a, b);

            //Assert
            Assert.Equal(expected, actual, 0);
        }
        [Fact]
        public void IsDivideWorks()
        {
            //arrange
            double a = 6;
            double b = 3;
            double expected = 2;

            //act
            var actual = _unitTesting.Divide(a, b);

            //Assert
            Assert.Equal(expected, actual, 0);
        }
        [Fact]
        public void IsMultiplyWorks()
        {
            //arrange
            double a = 5;
            double b = 3;
            double expected = 15;

            //act
            var actual = _unitTesting.Multiply(a, b);

            //Assert
            Assert.Equal(expected, actual, 0);
        }
        [Fact]
        public void IsSubtractWorks()
        {
            //arrange
            double a = 5;
            double b = 3;
            double expected = 2;

            //act
            var actual = _unitTesting.Subtract(a, b);

            //Assert
            Assert.Equal(expected, actual, 0);
        }


    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
