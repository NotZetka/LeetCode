using System;

namespace _4._Median_of_Two_Sorted_Arrays
{
    //public class Solution
    //{
    //    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    //    {
    //        int l1 = nums1.Length;
    //        int l2 = nums2.Length;
    //        int[] mergedArray = new int[l1+l2];
    //        int counter1 = 0;
    //        int counter2 = 0;
    //        for (int i = 0; i < l1+l2; i++)
    //        {
    //            if(counter1 == l1 || counter2 == l2)
    //            {
    //                while(counter2 < l2)
    //                {
    //                    mergedArray[i] = nums2[counter2];
    //                    counter2++;
    //                    i++;
    //                }
    //                while(counter1 < l1)
    //                {
    //                    mergedArray[i] = nums1[counter1];
    //                    counter1++;
    //                    i++;
    //                }
    //            }
    //            else if(nums1[counter1] < nums2[counter2])
    //            {
    //                mergedArray[i] = nums1[counter1];
    //                counter1++;
    //            }
    //            else
    //            {
    //                mergedArray[i] = nums2[counter2];
    //                counter2++;
    //            }
    //        }
    //        if(mergedArray.Length%2== 0)
    //        {
    //            return (mergedArray[mergedArray.Length/2] + mergedArray[mergedArray.Length / 2 -1])/2.0;
    //        }
    //        else
    //        {
    //            return (double)mergedArray[mergedArray.Length / 2];
    //        }
    //    }
    //}
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] smaller;
            int[] largeer;
            if (nums1.Length < nums2.Length)
            {
                smaller = nums1;
                largeer = nums2;
            }
            else
            {
                smaller = nums2;
                largeer = nums1;
            }
            bool even = (smaller.Length + largeer.Length) % 2 == 0 ? true : false;
            int start = 0;
            int end = smaller.Length;
            int dividerS;
            int dividerL;
            int smallL;
            int smallR;
            int largeL;
            int largeR;

            do
            {
                dividerS = (start + end) / 2;
                dividerL = (smaller.Length + largeer.Length + 1) / 2 - dividerS;
                smallL = (dividerS - 1) >= 0 ? smaller[dividerS - 1] : int.MinValue;
                smallR = (dividerS < smaller.Length) ? smaller[dividerS] : int.MaxValue;
                largeL = (dividerL>0)?largeer[dividerL - 1]:int.MinValue;
                largeR = (dividerL<largeer.Length)? largeer[dividerL]:int.MaxValue;
                if (smallL > largeR)
                {
                    end = dividerS-1;
                }
                if(largeL > smallR)
                {
                    start = dividerS+1;
                }

            } while (!(smallL <= largeR && largeL <= smallR));
            if (even)
            {
                return (Math.Min(smallR, largeR)+Math.Max(smallL,largeL))/2.0;
            }
            else
            {
                return Math.Max(smallL,largeL);
            }
    }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.FindMedianSortedArrays(new int[] { 1,3 }, new int[] { 2 }));
        }
    }
}
