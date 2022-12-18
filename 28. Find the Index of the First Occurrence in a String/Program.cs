using System;

namespace _28._Find_the_Index_of_the_First_Occurrence_in_a_String
{
    //public class Solution
    //{
    //    public int StrStr(string haystack, string needle)
    //    {
    //        bool found = false;
    //        for (int i = 0; i < haystack.Length-needle.Length+1; i++)
    //        {
    //            if(haystack[i] == needle[0])
    //            {
    //                found = true;
    //                for (int j = 1; j < needle.Length && found; j++)
    //                {
    //                    if (needle[j] != haystack[j+i])
    //                    {
    //                        found = false;
    //                    }
    //                }
    //                if (found) return i;
    //            }
    //        }
    //        return -1;
    //    }
    //}
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            for (int i = 0; i < haystack.Length-needle.Length+1; i++)
            {
                if(haystack.Substring(i,needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.StrStr("hello", "ll"));
            Console.WriteLine(solution.StrStr("sadbutsad","sad"));
        }
    }
}
