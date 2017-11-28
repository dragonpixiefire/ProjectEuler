using System;
using Xunit;
using ProjectEuler;

namespace ProjectEulerTests
{
    public class FibonacciTests
    {
        [Fact]
        public void HaveClass()
        {
            //Arrange
            Fibonacci fib;
            //Act
            fib = new Fibonacci(1, 2);

            //Assert
            Assert.NotNull(fib);
            
        }

 
    }
}
