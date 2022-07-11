using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }
        static Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
        public static int RomanToInt(string s)
        {
            int result = 0;
            int maxValue = 1;
            for (int i = s.Length-1; i>=0 ; i--)
            {
                if(maxValue <= dict[s[i]])
                {
                    if (maxValue < dict[s[i]])
                    {
                        maxValue = dict[s[i]];
                    }
                    result += maxValue;
                }
                else
                {
                    result -= dict[s[i]];
                }
            }
            return result;
        }

    }
}