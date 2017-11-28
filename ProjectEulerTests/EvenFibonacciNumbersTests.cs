using System;
using Xunit;
using ProjectEuler;

namespace ProjectEulerTests
{
    public class EvenFibonacciNumbersTests
    {

        [Fact]
        public void EvenFibonacci_1_0()
        {
            //Arrange
            int limit = 1;

            //Act
            int result = EvenFibonacciNumbers.Calculate(limit);

            //Assert
            Assert.Equal(0, result);


        }

        [Fact]
        public void EvenFibonacci_2_2()
        {
            //Arrange
            int limit = 2;

            //Act
            int result = EvenFibonacciNumbers.Calculate(limit);

            //Assert
            Assert.Equal(2, result);


        }
    }
}
