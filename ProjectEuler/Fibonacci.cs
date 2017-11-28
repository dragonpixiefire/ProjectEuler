using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class Fibonacci
    {
   
        public static List<int> Generate(int firstSequence, int secondSequence, int limit)
        {
            var result = new List<int>();
            if (firstSequence <= limit)
            {
                result.Add(firstSequence);
            }
            if (secondSequence <= limit)
            {
                result.Add(secondSequence);
            }
            if (result.Count == 2)
            {
                int sum = result[result.Count - 1] + result[result.Count - 2];
                while (result[result.Count - 1] + result[result.Count - 2] <= limit)
                {
                    result.Add(sum);

                }
            }

            return result;
        }
    }

 
}
