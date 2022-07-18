using System;
using System.Text;

namespace MyApp 
{
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            IList<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else if(i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else
                {
                    list.Add(Convert.ToString(i));
                }
            }
            return list;
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