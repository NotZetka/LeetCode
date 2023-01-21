using System;

namespace _72._Edit_Distance
{
    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            int [,] result = new int[word1.Length+1, word2.Length+1];
            for (int i = 0; i < word1.Length; i++)
            {
                result[word1.Length -1 - i, word2.Length] = i+1;
            }
            for (int j = 0; j < word2.Length; j++)
            {
                result[word1.Length, word2.Length - 1 - j] = j+1;
            }
            for (int i = word1.Length-1; i >= 0; i--)
            {
                for (int j = word2.Length-1;  j>=0; j--)
                {
                    if (word1[i] != word2[j])
                    {
                        result[i,j] = 1 + Math.Min(result[i+1,j+1],Math.Min(result[i + 1, j], result[i, j + 1]));
                    }
                    else
                    {
                        result[i,j] = result[i + 1, j + 1];
                    }
                }
            }
            return result[0, 0];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.MinDistance("abd","acd"));
        }
    }
}
