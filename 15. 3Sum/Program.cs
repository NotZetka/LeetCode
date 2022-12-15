using System;
using System.Collections.Generic;

namespace _15._3Sum
{

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int twoSum = nums[j] + nums[k];
                    int sum = nums[i] + twoSum;
                    if (sum == 0)
                    {
                        var result = new List<int>() { nums[i], nums[j], nums[k] };
                        results.Add(result);
                        while (result[1] == nums[j] && j<k) j++;
                        while (result[2] == nums[k] && k>j) k--;
                    }
                    else if (sum > 0)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
                while(nums[i] == nums[i+1] && i < nums.Length - 2) i++;
            }
            return results;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.ThreeSum(new[] { 0,0,0 });
        }
    }
}
