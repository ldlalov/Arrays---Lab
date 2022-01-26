using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int sumEven = 0;
                int sumOdd = 0;
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        sumEven += number;
                    }
                    else
                    {
                        sumOdd += number;
                    }
                }
                //Console.Write($"Even: {sumEven}");
                //Console.Write($"Odd: {sumOdd}");
                Console.Write($"{sumEven - sumOdd}");
            }
        }
    }
}
