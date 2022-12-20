using System;

namespace _31._Next_Permutation
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            int highest = int.MaxValue;
            for (int i = nums.Length-2; i >= 0; i--)
            {
                int index = nums.Length - 1;
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[j]>nums[i]&& nums[j] < highest)
                    {
                        highest = nums[j];
                        index = j;
                    }
                }
                if (highest != int.MaxValue)
                {
                    int temp = nums[i];
                    nums[i]=nums[index];
                    nums[index]=temp;
                    Array.Sort(nums, null, i+1, nums.Length - i -1);
                    break;
                }
            }
            if(highest == int.MaxValue)
            {
                Array.Reverse(nums);
            }
            foreach (var item in nums)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            //solution.NextPermutation(new int[] { 1, 2, 3 });
            //solution.NextPermutation(new int[] { 3,2,1 });
            //solution.NextPermutation(new int[] { 1,1,5 });
            solution.NextPermutation(new int[] { 1,3,2 });
        }
    }
}
