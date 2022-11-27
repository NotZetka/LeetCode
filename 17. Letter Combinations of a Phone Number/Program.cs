using System;
using System.Collections.Generic;

namespace _17._Letter_Combinations_of_a_Phone_Number
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> list = new List<string>();

            if (digits.Length == 0) return list;
            Dictionary<char, string> chars = new Dictionary<char, string>()
            {
                {'2',"abc"},
                {'3',"def"},
                {'4',"ghi"},
                {'5',"jkl"},
                {'6',"mno"},
                {'7',"pqrs"},
                {'8',"tuv"},
                {'9',"wxyz"},
            };
            helper(digits, "");
            void helper(string s,string result)
            {
                if (s == "") {
                    list.Add(result);
                        return;
                        }
                string _char = chars[s[0]];
                foreach(char c in _char)
                {
                    helper(s.Substring(1), result + c);
                }
            }

            return list;    
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LetterCombinations("23"));
        }
    }
}
