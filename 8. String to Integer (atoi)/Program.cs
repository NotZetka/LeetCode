using System;
using System.Text;

namespace _8._String_to_Integer__atoi_
{
    public class Solution
    {
        public int MyAtoi(string s)
        {

            bool positive = true;
            StringBuilder numbers = new StringBuilder();
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ') continue;
                else if (s[i] == '-')
                {
                    positive = false;
                    i++;
                    break;
                }
                else if (s[i] == '+')
                {
                    i++;
                    break;
                }
                else
                {
                    break;
                } 
            }
            for (int j = i; j < s.Length; j++)
            {
                if (s[j] >= '0' && s[j] <= '9')
                {
                    numbers.Append(s[j]);
                }
                else
                {
                    break;
                }
            }
            if (numbers.Length == 0)
            {
                return 0;
            }
            int value;
            try
            {
                value = Convert.ToInt32(numbers.ToString());
            }
            catch (Exception)
            {
                if (positive) return int.MaxValue;
                else return int.MinValue;
            }
            return positive ? value : -value;
        }
    }
    //}public int MyAtoi(string s)
    //    {
    //        if (s.Length == 0) return 0;
    //        bool positive = true;
    //        bool started = false;
    //        StringBuilder stringBuilder = new StringBuilder();
    //        foreach (char Char in s)
    //        {
    //            if (Char == '-')
    //            {
    //                if (started) break;
    //                started = true;
    //                positive = false;
    //                continue;
    //            }
    //            else if (Char == '+')
    //            {
    //                if (started) break;
    //                started = true;
    //                continue;
    //            }
    //            else if ((Char >= '0' && Char <= '9'))
    //            {
    //                stringBuilder.Append(Char);
    //                started = true;
    //                continue;
    //            }
    //            else if (started) break;
    //            else if (Char == ' ')
    //            {
    //                continue;
    //            }
    //            if (Char != ' ') return 0;
    //        }
    //        if (stringBuilder.Length == 0) return 0;
    //        int value;
    //        try
    //        {
    //            value = Convert.ToInt32(stringBuilder.ToString());
    //        }
    //        catch (Exception)
    //        {
    //            if (positive) return Int32.MaxValue;
    //            else return Int32.MinValue;
    //        }
    //        if (positive)
    //        {
    //            return Convert.ToInt32(stringBuilder.ToString());
    //        }
    //        else
    //        {
    //            return -Convert.ToInt32(stringBuilder.ToString());
    //        }
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.MyAtoi("42"));
            Console.WriteLine(solution.MyAtoi(" 42"));
            Console.WriteLine(solution.MyAtoi(" -42"));
            Console.WriteLine(solution.MyAtoi(" +-42"));
        }
    }
}
