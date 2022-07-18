using System;

namespace MyApp
{
    public class Solution
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < mat.Length; i++)
            {
                map.Add(i, mat[i].Sum());
            }
            var result = map.OrderBy(m => m.Value).Select(m => m.Key).Take(k).ToArray();
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] mat1 = new int[][] {
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 0, 0, 0 }
            };
            var res1 = solution.KWeakestRows(mat1, 2);
            Console.WriteLine();
        }
    }
}