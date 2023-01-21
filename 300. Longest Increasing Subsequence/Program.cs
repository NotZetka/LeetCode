using System;

namespace _300._Longest_Increasing_Subsequence
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            if(nums.Length == 0) return 0;
            int[] results = new int[nums.Length];
            int result = 1;
            results[^1] = 1;
            for (int i = 2; i <= nums.Length; i++)
            {
                results[^i] = 1;
                for (int j = i-1; j>0; j--)
                {
                    if (nums[^i] < nums[^j])
                    {
                        results[^i] = Math.Max(results[^i], results[^j]+1);
                    }
                }
                result = Math.Max(result, results[^i]);
            }
            
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });
            Console.WriteLine(result);
        }
    }
}
