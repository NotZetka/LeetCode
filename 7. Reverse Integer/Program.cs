using System;

namespace _7._Reverse_Integer
{
    public class Solution
    {

        public int Reverse(int x)
        {
            bool positive = true;
            long result = 0;
            long multiplier = 1;
            if (x < 0)
            {
                positive = false;
                x = -x;
            }
            while (x % 10 == 0 && x > 0)
            {
                x /= 10;
            }
            while (multiplier * 10 <= x)
            {
                multiplier *= 10;
            }
            while (x > 0)
            {
                int mod = x % 10;
                result += mod * multiplier;
                multiplier /= 10;
                x = x / 10;
            }
            if (result < Int32.MinValue || result > Int32.MaxValue) return 0;
            if (!positive)
            {
                return -Convert.ToInt32(result);
            }
            return Convert.ToInt32(result);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.Reverse(1534236469));
        }
    }
}
