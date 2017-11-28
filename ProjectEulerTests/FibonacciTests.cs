using System;
using Xunit;
using ProjectEuler;

namespace ProjectEulerTests
{
    public class FibonacciTests
    {
       [Fact]
        public void Generate_0_emptylist()
        {
            //Arrange
  
            int firstSequence = 1;
            int secondSequence = 2;
            int limit = 0;

            //Act
            var fibonacciResult = Fibonacci.Generate(firstSequence, secondSequence, limit);

            //Assert
            Assert.Equal(0, fibonacciResult.Count);

        }

        [Fact]
        public void Generate_1Limit1_1()
        {
            //Arrange

            int firstSequence = 1;
            int secondSequence = 2;
            int limit = 1;

            //Act
            var fibonacciResult = Fibonacci.Generate(firstSequence, secondSequence, limit);

            //Assert
            Assert.Equal(1, fibonacciResult[fibonacciResult.Count - 1]);

        }

        [Fact]
        public void Generate_2Limit1_2()
        {
            //Arrange

            int firstSequence = 1;
            int secondSequence = 2;
            int limit = 2;

            //Act
            var fibonacciResult = Fibonacci.Generate(firstSequence, secondSequence, limit);

            //Assert
            Assert.Equal(2, fibonacciResult[fibonacciResult.Count - 1]);

        }

        [Fact]
        public void Generate_3Limit3_3()
        {
            //Arrange

            int firstSequence = 1;
            int secondSequence = 2;
            int limit = 3;

            //Act
            var fibonacciResult = Fibonacci.Generate(firstSequence, secondSequence, limit);

            //Assert
            Assert.Equal(3, fibonacciResult[fibonacciResult.Count - 1]);

        }

    }
}
