using System;
using Xunit;
using ProjectEuler;

namespace ProjectEulerTests
{
    public class MultiplesOf3And5Tests
    {
        [Fact]
        public void Calculate_Limit10_23()
        {
            //Arrange
            int limit = 10;

            //Act
            int result = MultiplesOf3And5.Calculate(limit);

            //Assert
            Assert.Equal(23, result);
            
            
        }

        [Fact]
        public void Calculate_3Mod3_0()
        {
            int result = 3 % 3;
            Assert.Equal(0, result);
        }
    }
}
