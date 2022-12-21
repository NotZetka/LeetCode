using System;

namespace _34._Find_First_and_Last_Position_of_Element_in_Sorted_Array
{

    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int start = -1;
            int end = -1;
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] >= target)
                {
                    right = mid;
                }
                else
                {
                    left = mid+1;
                }
            }
            if(nums.Length>0 && nums[left] == target)
            {
                start = left;
                end = left;
                while(end + 1 < nums.Length && nums[end + 1] == target)
                {
                    end++;
                }
                while(start > 0 && nums[start - 1] == target)
                {
                    start--;
                }
            }
            return new int[] { start, end };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 },8));
            Console.WriteLine(solution.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 },6));
            Console.WriteLine(solution.SearchRange(new int[] { },0));
        }
    }
}
