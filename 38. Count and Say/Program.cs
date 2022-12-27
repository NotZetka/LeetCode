using System;
using System.Text;

namespace _38._Count_and_Say
{
    public class Solution
    {
        public string CountAndSay(int n)
        {
            string result = "1";
            for (int i = 1; i < n; i++)
            {
                result = helper(result);
            }
            return result;
        }
        private string helper(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            char c = s[0];
            int counter = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if(s[i] == c)
                {
                    counter++;
                }
                else
                {
                    stringBuilder.Append($"{counter}");
                    stringBuilder.Append(c);
                    c = s[i];
                    counter = 1;
                }
            }
            stringBuilder.Append($"{counter}");
            stringBuilder.Append(c);
            return stringBuilder.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.CountAndSay(1));
            Console.WriteLine(solution.CountAndSay(2));
            Console.WriteLine(solution.CountAndSay(3));
            Console.WriteLine(solution.CountAndSay(4));
        }
    }
}
