using System;

namespace MyApp
{
    public class Solution
    {
        public bool CanPartition(int[] nums)
        {
            bool canPartition = false;
            int sum = nums.Sum();
            if (sum % 2 != 0) return false;
            sum /= 2;
            int[][]? table = new int[nums.Length][];
            for (int i = 0; i < nums.Length; i++)
            {
                table[i] = new int[sum+1];
                Array.Fill(table[i], -1);
            }

            helper(nums.Length - 1, sum);


            void helper(int n, int c)
            {
                if (table[n][c] == -1 && !canPartition)
                {
                    table[n][c] = c;
                    if (c == 0) 
                    {
                        canPartition = true;
                    }
                    else if (n > 0)
                    {
                        helper(n - 1, c);
                        if (c >= nums[n])
                        {
                            helper(n - 1, c - nums[n]);
                        }
                    }
                }
            }
            return canPartition;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //int[] nums = { 1, 5, 11, 5 };
            //int[] nums = { 1, 2, 10, 5 };
            int[] nums = { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 99, 97 };
            Console.WriteLine(solution.CanPartition(nums));
        }
    }
}