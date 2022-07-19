using System;

namespace MyApp 
{
    public class Solution
    {
        public int NumberOfSteps2(int num)
        {
            return Helper(num, 0);
        }
        public int Helper(int num, int steps)
        {
            if (num == 0) return steps;
            if (num % 2 == 0) return Helper(num / 2, steps+1);
            else return Helper(num-1 , steps+1);
        }
        public int NumberOfSteps(int num)
        {
            int counter = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num = num/2;
                }
                else
                {
                    num--;
                }
                counter++;
            }
            return counter;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}