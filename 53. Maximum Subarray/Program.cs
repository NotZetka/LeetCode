using System;

namespace MyApp 
{
    class Solution
    {
        public int maxSubArray2(int[] nums)
        {
            int max = int.MinValue;
            int suma = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                suma = (suma < 0) ? nums[i] : suma+nums[i];
                
                if (suma > max) { max = suma; }
            }
            return max;
        }
        public int maxSubArray(int[] nums)
        {
            int[] maxes = new int[nums.Length];
            maxes[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                maxes[i] = Math.Max(nums[i], maxes[i-1] + nums[i]);
            }
            return maxes.Max();
        }
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 2, 1, -3, 10, 15, -2, 22, -9, 3 };
            int[] nums = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
            //int[] nums = {1,2};
            Solution solution = new Solution();
            Console.WriteLine(solution.maxSubArray(nums));
        }
    }
}