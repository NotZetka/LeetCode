using System;
using System.Collections.Generic;
using System.Text;

namespace _6._Zigzag_Conversion
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            List<StringBuilder> builders = new List<StringBuilder>();
            int i;
            for (i = 0; i < numRows; i++)
            {
                builders.Add(new StringBuilder());
            }
            int l = 0;
            i = 0;
            bool inc = true;
            while (l < s.Length)
            {
                builders[i].Append(s[l]);
                l++;
                if(numRows > 1)
                {
                    if (inc) { i++; }
                    else { i--; }
                    if (i == 0 || i == numRows - 1) { inc = !inc; }
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var builder in builders)
            {
                sb.Append(builder);
            }
            return sb.ToString();
        }

    }
    //public class Solution
    //{
    //    public string Convert(string s, int numRows)
    //    {
    //        List<string> rows = new();
    //        int l = s.Length;
    //        StringBuilder stringBuilder = new StringBuilder();
    //        while (l > 0)
    //        {
    //            for (int i = 0; i < numRows; i++)
    //            {
    //                if (l == 0) stringBuilder.Append(' ');
    //                else
    //                {
    //                    stringBuilder.Append(s[s.Length - l]);
    //                    l--;
    //                }
    //            }
    //            rows.Add(stringBuilder.ToString());
    //            stringBuilder.Clear();
    //            if (l == 0) break;
    //            for (int j = 1; j < numRows - 1; j++)
    //            {
    //                for (int i = 0; i < numRows; i++)
    //                {
    //                    if (i == numRows - j - 1 && l != 0)
    //                    {
    //                        stringBuilder.Append(s[s.Length - l]);
    //                        l--;
    //                    }
    //                    else
    //                    {
    //                        stringBuilder.Append(' ');
    //                    }
    //                }
    //                rows.Add(stringBuilder.ToString());
    //                stringBuilder.Clear();
    //            }
    //        }
    //        for (int i = 0; i < numRows; i++)
    //        {
    //            foreach (var item in rows)
    //            {
    //                if (item[i] != ' ')
    //                {
    //                    stringBuilder.Append(item[i]);
    //                }
    //            }
    //        }

    //        return stringBuilder.ToString();
    //    }

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.Convert("AB", 1);
            Console.WriteLine(result);
        }
    }
}
