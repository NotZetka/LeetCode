using System;
using System.Collections.Generic;

namespace _41._First_Missing_Positive
{
    //public class Solution
    //{
    //    public int FirstMissingPositive(int[] nums)
    //    {
    //        int result = 1;
    //        Array.Sort(nums);
    //        foreach (var item in nums)
    //        {
    //            if (item == result)
    //            {
    //                result++;
    //            }
    //        }
    //        return result;
    //    }
    //}
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            int l = nums.Length;
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            for (int i = 1; i <= l; i++)
            {
                dict[i] = false;
            }
            foreach (var item in nums)
            {
                if(item <= l && item>0)
                {
                    dict[item] = true;
                }
            }
            foreach(var item in dict)
            {
                if(!item.Value) return item.Key;
            }   
            return l+1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
