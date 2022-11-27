using System;

namespace _11._Container_With_Most_Water
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int result = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                int width = right - left;
                int curResult = minHeight * width;
                result = Math.Max(result, curResult);
                if(height[left] < height[right]) left++;
                else if(height[left] > height[right]) right--;
                else
                {
                    left++;
                    right--;
                }
            }
            return result;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] height = { 1, 8, 6, 2, 5, 12, 8, 3, 7 };
            //int[] height = { 1, 1 };
            Console.WriteLine(solution.MaxArea(height));
        }
    }
}
