using System;

namespace MyApp 
{
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            foreach (var customer in accounts)
            {
                int balance = customer.Sum();
                if(balance > max) { max = balance; };
            }
            return max;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}