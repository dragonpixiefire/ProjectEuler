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


        [Fact]
        public void Problem1Solution_1000_233168()
        {
            //Act
            int result = MultiplesOf3And5.Calculate(1000);

            //Assert
            Assert.Equal(233168, result);
        }
    }
}
