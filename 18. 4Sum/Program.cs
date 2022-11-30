using System;
using System.Collections.Generic;

namespace _18._4Sum
{
    //public class Solution
    //{
    //    public IList<IList<int>> FourSum(int[] nums, int target)
    //    {
    //        Array.Sort(nums);
    //        IList<IList<int>> result = new List<IList<int>>();
    //        for (int i = 0; i < nums.Length-3; i++)
    //        {
    //            int[] newNums = new int[nums.Length - i - 1];
    //            Array.Copy(nums, i + 1, newNums,0, nums.Length - i - 1);
    //            var curResult = ThreeSum(newNums, (long)target - nums[i]);
    //            foreach (var res in curResult)
    //            {
    //                res.Add(nums[i]);
    //                result.Add(res);
    //            }
    //            while (nums[i] == nums[i + 1] && i < nums.Length - 3) i++;
    //        }
    //        return result;
    //    }
    //    public IList<IList<int>> ThreeSum(int[] nums, long target)
    //    {
    //        IList<IList<int>> results = new List<IList<int>>();
    //        Array.Sort(nums);
    //        for (int i = 0; i < nums.Length - 2; i++)
    //        {
    //            int j = i + 1;
    //            int k = nums.Length - 1;
    //            while (j < k)
    //            {
    //                long twoSum = nums[j] + nums[k];
    //                long sum = nums[i] + twoSum;
    //                if (sum == target)
    //                {
    //                    var result = new List<int>() { nums[i], nums[j], nums[k] };
    //                    results.Add(result);
    //                    while (result[1] == nums[j] && j < k) j++;
    //                    while (result[2] == nums[k] && k > j) k--;
    //                }
    //                else if (sum > target)
    //                {
    //                    k--;
    //                }
    //                else
    //                {
    //                    j++;
    //                }
    //            }
    //            while (nums[i] == nums[i + 1] && i < nums.Length - 2) i++;
    //        }
    //        return results;
    //    }
    //}
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> results = new List<IList<int>>();
            if (nums.Length < 4) return results;
            Array.Sort(nums);
            long lastTwoSum = Convert.ToInt64(nums[^1]) + nums[^2];
            long lastThreeSum = Convert.ToInt64(nums[^1]) + nums[^2] + nums[^3];
            for (int a = 0; a < nums.Length-3; a++)
            {
                if (nums[a] + lastThreeSum < target) continue;
                if (Convert.ToInt64(nums[a]) + nums[a+1]+ nums[a+2]+nums[a+3] > target) break;
                if (a > 0 && nums[a] == nums[a - 1]) continue;
                for (int b = a+1; b < nums.Length-2; b++)
                {
                    if (Convert.ToInt64(nums[a]) + nums[b] + lastTwoSum < target) continue;
                    if (Convert.ToInt64(nums[a]) + nums[b] + nums[b+1] + nums[b+2] > target) break;
                    if(b>a+1 && nums[b] == nums[b-1]) continue;
                    for (int c = b+1; c < nums.Length-1; c++)
                    {
                        if (c > b+1 && nums[c] == nums[c - 1]) continue;
                        for (int d = nums.Length-1; d > c; d--)
                        {
                            if(d<nums.Length-1 && nums[d] == nums[d+1]) continue;
                            if (Convert.ToInt64(nums[a]) + nums[b] + nums[c] + nums[d] == target)
                            {
                                results.Add(new List<int> { nums[a], nums[b], nums[c], nums[d] });
                            }
                        }
                    }
                }
            }
            return results;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.FourSum(new int[]{0, 0, 0, -1000000000, -1000000000, -1000000000, -1000000000},-1000000000));
        }
    }
}
