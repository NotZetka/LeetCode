using System;
using System.Collections.Generic;

namespace _45._Jump_Game_II
{
    //public class Solution
    //{
    //    public int Jump(int[] nums)
    //    {
    //        return helper(nums, 0);
    //    }
    //    private int helper(int[]nums, int position) { 
    //        if(nums.Length-1<=position) return 0;
    //        int range = nums[position];
    //        int result = int.MaxValue-1; 
    //        for (int i = 1; i <= range; i++)
    //        {
    //            result = Math.Min(result, helper(nums, position+i));
    //        }
    //        return 1 + result;
    //    }
    //}
    //public class Solution
    //{
    //    public int Jump(int[] nums)
    //    {
    //        int[] result = new int[nums.Length];
    //        for (int i = 1; i < nums.Length; i++)
    //        {
    //            result[i] = int.MaxValue;
    //        }
    //        int position = 0;
    //        while (position < nums.Length)
    //        {
    //            int range = nums[position];
    //            for (int i = 1; i <= range; i++)
    //            {
    //                if (position + i >= nums.Length) continue;
    //                result[position+i] = Math.Min(1+result[position],result[position+i]);
    //            }
    //            position++;
    //        }
    //        return result[^1];
    //    }
        
    //}
    public class Solution
    {
        public int Jump(int[] nums)
        {
            int result = 0;
            int left = 0;
            int right = 0;
            int farthest = 0;
            while(right < nums.Length-1)
            {
                for (int i = left; i <= right; i++)
                {
                    farthest = Math.Max(farthest, i+nums[i]);
                }
                result++;
                left = right + 1;
                right = farthest;
            }
            return result;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.Jump(new int[]
            {
                5,6,4,4,6,9,4,4,7,4,4,8,2,6,8,1,5,9,6,5,2,7,9,7,9,6,9,4,1,6,8,8,4,4,2,0,3,8,5
                
            }));
        }
    }
}
