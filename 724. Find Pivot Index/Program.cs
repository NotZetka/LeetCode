using System;

namespace MyApp 
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            int right = nums.Sum();
            int left = 0;
            int current;
            for (int i = 0; i < nums.Length; i++)
            {
                current = nums[i];
                right-=current;
                if (left == right) { return i; }
                left+=current;
            }
            return -1;
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