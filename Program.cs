using System;
using System.Numerics;

namespace FibonacciModified
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.Write("Enter t0, t1 and n value with space character : ");
            string[] inputs = Console.ReadLine().TrimEnd().Split(' ');

            int t0=0;
            int t1=0;
            int n = 0;
            if (inputs.Length>0)
            {
                t0 = int.Parse(inputs[0]);
                t1 = int.Parse(inputs[1]);
                n = int.Parse(inputs[2]);

            }

            BigInteger res = fibonacciModified(t0, t1, n);

            Console.WriteLine(res);
            //84266613096281243382112
        }

        private static BigInteger fibonacciModified(long t0, long t1, int n)
        {
            BigInteger tempT0 = t0;
            BigInteger tempT1 = t1;
            BigInteger res = 0;


            for (int i = 0; i < n-1; i++)
            {
                BigInteger fib = tempT0 + (tempT1 * tempT1);

                res = tempT1;
                tempT0 = tempT1;
                tempT1 = fib;
                
            }

            return res;
        }
    }
}
