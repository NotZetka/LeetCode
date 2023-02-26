using System;

namespace _1143._Longest_Common_Subsequence
{
    public class Solution
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] result = new int[text1.Length+1, text2.Length+1];
            for (int i = text1.Length-1; i >= 0; i--)
            {
                for (int j = text2.Length-1; j >= 0 ; j--)
                {
                    if (text1[i] == text2[j])
                    {
                        result[i,j] = 1+ result[i+1, j+1];
                    }
                    else
                    {
                        result[i,j] = Math.Max(result[i+1, j], result[i, j+1]);
                    }
                }
            }
            return result[0,0];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LongestCommonSubsequence("abcde", "ace"));
        }
    }
}
