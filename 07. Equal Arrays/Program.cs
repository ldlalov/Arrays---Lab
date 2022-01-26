using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] area1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] area2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < area1.Length; i++)
            {
                if (area1[i] != area2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                    sum += area1[i];
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
