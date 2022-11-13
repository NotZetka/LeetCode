using System;

namespace _10._Regular_Expression_Matching
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] result = new bool[s.Length + 1, p.Length + 1];
            result[0, 0] = true;
            for (int j = 1; j < p.Length; j++)
            {
                if (p[j] == '*')
                {
                    result[0, j + 1] = result[0, j-1];
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                //for (int k = 0; k < s.Length + 1; k++)
                //{
                //    for (int l = 0; l < p.Length + 1; l++)
                //    {
                //        Console.Write(result[k, l] ? "1" : "0");
                //        Console.Write("");
                //    }
                //    Console.WriteLine();
                //}
                //Console.WriteLine();
                for (int j = 0; j < p.Length; j++)
                {
                    if (s[i] == p[j] || p[j] == '.')
                    {
                        result[i + 1, j + 1] = result[i, j];
                    }
                    else if (p[j] == '*')
                    {
                        result[i + 1, j + 1] |= result[i + 1, j-1];
                        if (p[j - 1] == '.' || p[j - 1] == s[i])
                        {
                            result[i + 1, j + 1] |= (result[i, j+1]);
                        }
                    }
                }
            }
            return result[s.Length, p.Length];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsMatch("aaba","ab*a*c*a"));//false
            Console.WriteLine(solution.IsMatch("aa","a"));//false
            Console.WriteLine(solution.IsMatch("aaa", "ab*a"));//false
            Console.WriteLine(solution.IsMatch("ab", ".*c"));//false
            Console.WriteLine(solution.IsMatch("aa","a*"));//true
            Console.WriteLine(solution.IsMatch("ab",".*"));//true
            Console.WriteLine(solution.IsMatch("aab","c*a*b"));//true
            Console.WriteLine(solution.IsMatch("mississippi","mis*is*ip*."));//true
            Console.WriteLine(solution.IsMatch("aaa","ab*a*c*a"));//true
            Console.WriteLine(solution.IsMatch("xaabyc", "xa*b.c"));//true
        }
    }
}
