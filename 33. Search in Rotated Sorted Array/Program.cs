using System;

namespace _33._Search_in_Rotated_Sorted_Array
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            int left = 0;
            int right = nums.Length - 1;
            while(left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] >= nums[left] && target<= nums[mid] && target >= nums[left])
                {
                    right = mid;
                }else if(nums[mid+1] <= nums[right] && target >= nums[mid + 1] && target <= nums[right])
                {
                    left = mid + 1;
                }else if(nums[mid] < nums[left])
                {
                    right = mid;
                }
                else
                {
                    left = mid+1;
                }
            }
            if (nums[left] == target)
            {
                return left;
            }
            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 },0));
            Console.WriteLine(solution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 },3));
            Console.WriteLine(solution.Search(new int[] { 1 },0));
        }
    }
}
