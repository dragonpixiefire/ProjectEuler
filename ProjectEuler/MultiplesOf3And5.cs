using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class MultiplesOf3And5
    {

        public static int Calculate(int limit)
        {
            var sum = 0;
            for(int i =0; i<limit; i++)
            {
                if(i%3==0 || i%5==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
