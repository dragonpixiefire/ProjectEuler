using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class EvenFibonacciNumbers
    {
        public static int Calculate(int limit)
        {
            var fibionacciSequence = Fibonacci.Generate(1, 2, limit);
            int sum = 0;
            foreach (int sequence in fibionacciSequence)
            {
                if (sequence % 2 == 0)
                {
                    sum += sequence;
                }
            }

  
            return sum;
        }


    }
}
