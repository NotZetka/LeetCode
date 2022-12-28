using System;

namespace _42._Trapping_Rain_Water
{
    //public class Solution
    //{
    //    public int Trap(int[] height)
    //    {
    //        if(height.Length <=2) return 0;
    //        int result = 0;
    //        int startHeight = -1;
    //        int endHeight = -1;
    //        int startTemp = 0;
    //        int endTemp = 0;
    //        int start = 0;
    //        int end = height.Length - 1;
    //        while (startHeight < height[start])
    //        {
    //            startHeight = height[start];
    //            start++;
    //        }
    //        while (endHeight < height[end])
    //        {
    //            endHeight = height[end];
    //            end--;
    //        }
    //        if (end == start)
    //        {
    //            result += (Math.Min(startHeight,endHeight)-height[start]);
    //        }
    //        for (; end>start;)
    //        {
    //            int j = start;
    //            while (j < height.Length && startHeight > height[j])
    //            {
    //                startTemp += (startHeight - height[j]);
    //                j++;
    //            }
    //            if (j < height.Length)
    //            {
    //                result += startTemp;
    //                startTemp = 0;
    //                startHeight = height[j];
    //                start = j + 1;
    //            }
    //            if(end > start)
    //            {
    //                j = end;
    //                while (j >= 0 && endHeight > height[j])
    //                {
    //                    endTemp += (endHeight - height[j]);
    //                    j--;
    //                }
    //                if (j >= 0)
    //                {
    //                    result += endTemp;
    //                    endTemp = 0;
    //                    endHeight = height[j];
    //                    end = j - 1;
    //                }
    //            }
    //        }
    //        return result;
    //    }
    //}
    //public class Solution
    //{
    //    public int Trap(int[] height)
    //    {
    //        int result = 0;
    //        int curHeight = -1;
    //        int maxHeight=-1;
    //        int maxHeightIndex = height.Length-1;
    //        for (int i = 0; i < height.Length; i++)
    //        {
    //            if(height[i] > maxHeight)
    //            {
    //                maxHeight = height[i];
    //                maxHeightIndex = i;
    //            }
    //        }

    //        int temp = 0;
    //        for (int i = 0; i <= maxHeightIndex;)
    //        {
    //            int j = i;
    //            while (j <= maxHeightIndex && curHeight > height[j])
    //            {
    //                temp += (curHeight - height[j]);
    //                j++;
    //            }
    //            if (j <= maxHeightIndex)
    //            {
    //                result += temp;
    //                temp = 0;
    //                curHeight = height[j];
    //                i = j + 1;
    //            }
    //            else
    //            {
    //                temp = 0;
    //                curHeight = height[i];
    //                i++;
    //            }
    //        }
    //        curHeight = -1;
    //        for (int i = height.Length-1; i >= maxHeightIndex;)
    //        {
    //            int j = i;
    //            while (j >= maxHeightIndex && curHeight > height[j])
    //            {
    //                temp += (curHeight - height[j]);
    //                j--;
    //            }
    //            if (j >= maxHeightIndex)
    //            {
    //                result += temp;
    //                temp = 0;
    //                curHeight = height[j];
    //                i = j - 1;
    //            }
    //            else
    //            {
    //                temp = 0;
    //                curHeight = height[i];
    //                i--;
    //            }
    //        }
    //        return result;
    //    }
    //}
    //public class Solution
    //{
    //    public int Trap(int[] height)
    //    {
    //        int[] maxLeft = new int[height.Length];
    //        int[] maxRight = new int[height.Length];
    //        int result = 0;
    //        maxLeft[0]=0;
    //        maxRight[^1]=0;
    //        for (int i = 1; i < height.Length; i++)
    //        {
    //            maxLeft[i]=Math.Max(maxLeft[i-1],height[i-1]);
    //            maxRight[^(i+1)]=Math.Max(maxRight[^i],height[^i]);
    //        }
    //        for (int i = 1; i < height.Length-1; i++)
    //        {
    //            result+=Math.Max(
    //                Math.Min(maxLeft[i],maxRight[i])-height[i],0
    //                );
    //        }
    //        return result;
    //    }
    //}  
    public class Solution
    {
        public int Trap(int[] height)
        {
            if (height.Length <= 2) return 0;
            int maxLeft = height[0];
            int maxRight = height[^1];
            int result = 0;
            int left = 0;
            int right =  height.Length - 1;
            while (left < right)
            {
                if (maxLeft <= maxRight)
                {
                    left++;
                    result +=Math.Max(0,maxLeft-height[left]);
                    maxLeft = Math.Max(maxLeft,height[left]);
                }
                else
                {
                    right--;
                    result += Math.Max(0, maxRight - height[right]);
                    maxRight = Math.Max(maxRight, height[right]);
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
            int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            //int[] height = new int[] { 2,1,0,2 };
            Console.WriteLine(solution.Trap(height));
        }
    }
}
