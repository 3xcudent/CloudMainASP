using CloudMainASP.CloudMianASPTest;
using System;
using Xunit;

namespace CloudMainASP.Testy
{
    public class CloudMainASPTest
    {
        private plikj _Test = null;

        public CloudMainASPTest()
        {
            if (_Test == null)
            {
                _Test = new plikj();
            }
        }

        [Fact]
        public void Delta()
        {
            double a = 5;
            double b = 3;
            double c = 4;
            double expected = -71;

            var actual = _Test.Delta(a, b, c);

            Assert.Equal(expected, actual, 0);
        }
        [Fact]
        public void PoleTrojkata()
        {
            double a = 5;
            double b = 4;
            double expected = 10;

            var actual = _Test.PoleTrojkata(a, b);

            Assert.Equal(expected, actual, 0);
        }
        [Fact]
        public void Odejmowanie()
        {
     
            double a = 5;
            double b = 3;
            double expected = 2;
         
            var actual = _Test.Odejmowanie(a, b);
  
            Assert.Equal(expected, actual, 0);
        }
     
    }
}
