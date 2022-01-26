using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray(); 
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine("{0} => {1}", numbers[i],(int)Math.Round(numbers[i],MidpointRounding.AwayFromZero));
            }
        }
    }
}
