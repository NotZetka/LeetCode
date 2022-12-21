using System;
using System.Collections.Generic;

namespace _32._Longest_Valid_Parentheses
{
    //public class Solution
    //{
    //    public int LongestValidParentheses(string s)
    //    {
    //        int start = 0;
    //        while (start < s.Length && s[start] != '(')
    //        {
    //            start++;
    //        }
    //        return helper(s,start);
    //    } 
    //    private int helper(string s, int start)
    //    {
    //        if(start >= s.Length) return 0;
    //        if(s[start] == ')') return helper(s,start+1);
    //        int openCounter = 1;
    //        int closeCounter = 0;
    //        int end = start + 1;
    //        int result = 0;
    //        while (end < s.Length && openCounter>=closeCounter)
    //        {
    //            if (s[end] == '(')
    //            {
    //                openCounter++;
    //            }
    //            else
    //            {
    //                closeCounter++;
    //            }
    //            end++;
    //            if(openCounter == closeCounter)
    //            {
    //                result = end - start;
    //            }
    //        }
    //        return Math.Max(result, helper(s, start + 1));
    //    }
    //}
    public class Solution
    {
        public int LongestValidParentheses(string s)
        {
            int result = 0;
            int openCounter = 0;
            int closeCounter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    openCounter++;
                }
                else
                {
                    closeCounter++;
                }
                if(openCounter == closeCounter)
                {
                    result = Math.Max(result, openCounter+closeCounter);
                }else if(closeCounter > openCounter)
                {
                    openCounter = 0;
                    closeCounter = 0;
                }
            }
            openCounter = 0;
            closeCounter = 0;
            for (int i = s.Length-1; i >= 0 ; i--)
            {
                if (s[i] == '(')
                {
                    openCounter++;
                }
                else
                {
                    closeCounter++;
                }
                if(openCounter == closeCounter)
                {
                    result = Math.Max(result, openCounter+closeCounter);
                }else if(closeCounter < openCounter)
                {
                    openCounter = 0;
                    closeCounter = 0;
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
            Console.WriteLine(solution.LongestValidParentheses("(()"));
            Console.WriteLine(solution.LongestValidParentheses(")()())"));
            Console.WriteLine(solution.LongestValidParentheses(")"));
            Console.WriteLine(solution.LongestValidParentheses("()(()"));
            Console.WriteLine(solution.LongestValidParentheses("))))((()(("));
            Console.WriteLine(solution.LongestValidParentheses(")()())()()("));
            Console.WriteLine(solution.LongestValidParentheses("))))((()(("));//2
            Console.WriteLine(solution.LongestValidParentheses(")(())))(())())"));//6
            Console.WriteLine(solution.LongestValidParentheses("()(()"));//2
            }
        }
    }

