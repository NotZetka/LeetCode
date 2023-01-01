using System;

namespace _44._Wildcard_Matching
{
    //public class Solution
    //{
    //    public bool IsMatch(string s, string p)
    //    {
    //        return helper(s, p, 0, 0);
    //    }
    //    private bool helper(string s, string p,int i, int j)
    //    {
    //        if (i == s.Length)
    //        {
    //            if(j==p.Length) return true;
    //            if(p[j]=='*') return helper(s,p,i,j+1);
    //        }
    //        if (i == s.Length || j == p.Length) return false;
    //        if (s[i] == p[j]||p[j]=='?')
    //        {
    //            return helper(s,p,i+1,j+1);
    //        }else if(p[j] == '*')
    //        {
    //            return (helper(s, p, i + 1,j)|| helper(s, p,i, j+1) || helper(s, p, i + 1, j + 1));
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] result = new bool[s.Length + 1, p.Length + 1];
            result[0,0] = true;
            for (int i = 1; i <= p.Length; i++)
            {
                if (p[i - 1] == '*')
                {
                    result[0,i] = result[0,i-1];
                }
            }
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (s[i - 1] == p[j - 1] || '?' == p[j - 1])
                    {
                        result[i,j] = result[i-1,j-1];
                    }else if('*' == p[j - 1])
                    {
                        result[i,j]=(result[i-1,j]||result[i,j-1]);
                    }
                }
            }
            return result[s.Length,p.Length];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsMatch("aa", "a"));//false
            Console.WriteLine(solution.IsMatch("aa", "*"));//true
            Console.WriteLine(solution.IsMatch("cb", "?a"));//false
            Console.WriteLine(solution.IsMatch("mississippi", "m??*ss*?i*pi"));//false
            Console.WriteLine(solution.IsMatch("abcdef", "a?c*f"));//true
            Console.WriteLine(solution.IsMatch("adceb", "*a*b"));//true
            Console.WriteLine(solution.IsMatch("", "*****"));//true
        }
    }
}
