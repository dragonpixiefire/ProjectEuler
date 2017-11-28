using System;

namespace ProjectEuler
{
    class Program
    {
        public static void Main(string[] args)
        {
            int problem1 = MultiplesOf3And5.Calculate(1000);
            Console.WriteLine(problem1);

            int problem2 = EvenFibonacciNumbers.Calculate(4000000);
            Console.WriteLine(problem2);

            Console.ReadKey();
         
        }
    }
}
