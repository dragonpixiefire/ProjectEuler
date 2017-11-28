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

    }
}
