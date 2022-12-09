using System;
using System.Collections.Generic;

namespace _22._Generate_Parentheses
{
    public class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            string parenthes = "";
            helper(parenthes, n,n);
            void helper(string s, int opening, int closing)
            {
                if(opening==0 && closing==0)
                {
                    result.Add(s);
                }
                else
                {
                    if (opening == closing && opening > 0)
                    {
                        helper(s+"(", opening-1, closing);
                    }
                    else if (opening < closing && opening > 0)
                    {
                        helper(s + "(", opening - 1, closing);
                        helper(s + ")", opening, closing-1);
                    }else if(opening == 0 && closing > 0)
                    {
                        helper(s + ")", opening, closing - 1);
                    }
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
            solution.GenerateParenthesis(3);
        }
    }
}
