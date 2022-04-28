using System;
using System.Collections;
using Xunit;

namespace PIApproximation.Test
{
    public class CalculateDecimalsOfIrrationalNumberPITest
    {
        [Fact]
        public void IterrationsAndApproximationTest1_Successful()
        {
            //Arrange
            ICalculateDecimalsOfIrrationalNumberPI calculateDecimalsOfIrrationalNumberPI = new CalculateDecimalsOfIrrationalNumberPI();
            ArrayList expected = new ArrayList { 10, 3.0418396189 };
            double epsilon = 0.1;

            //Act
            var actual = calculateDecimalsOfIrrationalNumberPI.IterrationsAndApproximation(epsilon);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IterrationsAndApproximationTest2_Successful()
        {
            //Arrange
            ICalculateDecimalsOfIrrationalNumberPI calculateDecimalsOfIrrationalNumberPI = new CalculateDecimalsOfIrrationalNumberPI();
            ArrayList expected = new ArrayList { 1000, 3.1405926538 };
            double epsilon = 1000, 3.1405926538;

            //Act
            var actual = calculateDecimalsOfIrrationalNumberPI.IterrationsAndApproximation(epsilon);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
