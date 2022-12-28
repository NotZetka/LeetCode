using System;
using System.Text;

namespace _43._Multiply_Strings
{
    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";
            if (num1.Length < num2.Length)
            {
                var temp = num1;
                num1 = num2;
                num2 = temp;
            }
            int[] nums1 = new int[num1.Length]; //longer
            int[] nums2 = new int[num2.Length]; 
            int[] result = new int[num1.Length + num2.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                nums1[i] = num1[i]-48;
            }
            for (int i = 0; i < num2.Length; i++)
            {
                nums2[i] = num2[i]-48;
            }
            for (int i = 1; i <= num2.Length; i++)
            {
                for (int j = 1; j <= num1.Length; j++)
                {
                    int curRes = result[^(i + j - 1)] + nums1[^j] * nums2[^i];
                    result[^(i + j - 1)] = curRes % 10;
                    result[^(i + j)] += curRes / 10;
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            int k =0;
            while(result[k] == 0)
            {
                k++;
            }
            while (k < result.Length)
            {
                stringBuilder.Append(result[k]);
                k++;
            }
            return stringBuilder.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.Multiply("9133", "0"));
        }
    }
}
