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
  
            int firstTerm = 1;
            int secondTerm = 2;
            int limit = 0;
            var fib = new Fibonacci(firstTerm, secondTerm);

            //Act
            var fibonacciResult = fib.Generate(limit);

            //Assert
            Assert.Equal(0, fibonacciResult.Count);

        }

        [Fact]
        public void Generate_1Limit1_1()
        {
            //Arrange

            int firstTerm = 1;
            int secondTerm = 2;
            int limit = 1;
            var fib = new Fibonacci(firstTerm, secondTerm);

            //Act
            var fibonacciResult = fib.Generate(limit);

            //Assert
            Assert.Equal(1, fibonacciResult[fibonacciResult.Count - 1]);

        }

        [Fact]
        public void Generate_2Limit1_2()
        {
            //Arrange

            int firstTerm = 1;
            int secondTerm = 2;
            int limit = 2;
            var fib = new Fibonacci(firstTerm, secondTerm);

            //Act
            var fibonacciResult = fib.Generate(limit);

            //Assert
            Assert.Equal(2, fibonacciResult[fibonacciResult.Count - 1]);

        }

        [Fact]
        public void Generate_3Limit3_3()
        {
            //Arrange

            int firstTerm = 1;
            int secondTerm = 2;
            int limit = 3;
            var fib = new Fibonacci(firstTerm, secondTerm);

            //Act
            var fibonacciResult = fib.Generate(limit);

            //Assert
            Assert.Equal(3, fibonacciResult[fibonacciResult.Count - 1]);

        }



    }
}
