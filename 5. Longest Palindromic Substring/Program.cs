using System;
using System.Linq;
using System.Text;

namespace _5._Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if(s.Length<=1) return s;
            int length = s.Length;
            string[] results = new string[s.Length];
            for (int i = 0; i < length; i++)
            {
                StringBuilder result = new StringBuilder();
                result.Append(s[i]);
                int j = 1;
                while(i-j>=0 && i+j<length && s[i - j] == s[j + i])
                {
                    result.Insert(0,s[i-j]);
                    result.Append(s[i+j]);
                    j++;
                }
                StringBuilder result2 = new StringBuilder();
                if (i+1<length && s[i] == s[i + 1])
                {
                    result2.Append(s[i]);
                    result2.Append(s[i+1]);
                    j = 1;
                    while (i - j >= 0 && i + j + 1 < length && s[i - j] == s[j + i + 1])
                    {
                        result2.Insert(0,s[i - j]);
                        result2.Append(s[i + j + 1]);
                        j++;
                    }
                }
                if (result.Length > result2.Length)
                {
                    results[i] = result.ToString();
                }
                else
                {
                    results[i] = result2.ToString();
                }
            }
            return results.OrderByDescending(x => x.Length).FirstOrDefault();
        }   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LongestPalindrome("babad"));
            //Console.WriteLine(solution.LongestPalindrome("aaaa"));
        }
    }
}
