using System;

namespace Euler1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Optimized method with continuous sum function
            int sum = 0;
            int a = 3;
            int b = 5;
            int range = 999; //range has to be either range or raneg -1 so that value isn't a multiple
            int aprime = ContinuousSum(range/a);
            int bprime = ContinuousSum(range/b); 
            int common = ContinuousSum(range/(a*b));
            int sum1 = a*aprime + b*bprime - a*b*common;
            Console.WriteLine(sum1);

            // a Super slow iterative method
            for (int i = 3 ; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = i + sum;
                }
            }
            Console.WriteLine(sum);
        }
        static public int ContinuousSum(int x)
        {
            int result = x*(x+1)/2;
            return result;
        }
    }
}
