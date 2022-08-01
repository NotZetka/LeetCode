using System;
using System.Text;

namespace MyApp 
{
    public class Solution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> solutions = new List<IList<string>>();
            for (int i = 0; i < n; i++)
            {
                IList<int> solution = new List<int>();
                bool[] columns = new bool[n];
                solution.Add(i);
                columns[i] = true;
                bool[] diagonallBottomTop = new bool[2*n-1];
                bool[] diagonallTopBottom = new bool[2*n-1];
                diagonallBottomTop[i] = true;
                diagonallTopBottom[n-1+i] = true;
                helper(columns, diagonallBottomTop, diagonallTopBottom, solution, 1);

            }
            void helper(bool[] columns, bool[] diagonallBottomTop, bool[] diagonallTopBottom, IList<int> solution, int row)
            {
                if (row == n)
                {
                    solutions.Add(solutionToString(solution));
                }
                for (int i = 0; i < n; i++)
                {
                    if (columns[i]) continue;
                    if (diagonallBottomTop[i+row]) continue;
                    if (diagonallTopBottom[n-1+i-row]) continue;

                    solution.Add(i);
                    columns[i] = true;
                    diagonallBottomTop[i + row] = true;
                    diagonallTopBottom[n - 1 + i - row] = true;
                    helper(columns, diagonallBottomTop, diagonallTopBottom, solution, row + 1);

                    solution.RemoveAt(solution.Count-1);
                    columns[i] = false;
                    diagonallBottomTop[i + row] = false;
                    diagonallTopBottom[n - 1 + i - row] = false;

                }
            }
            IList<string> solutionToString(IList<int> solution)
            {
                IList<string> vs = new List<string>();
                foreach (var item in solution)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < n; i++)
                    {
                        if (i == item) stringBuilder.Append("Q");
                        else stringBuilder.Append(".");
                    }
                    vs.Add(stringBuilder.ToString());
                }
                return vs;
            }
            return solutions;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.SolveNQueens(4);
            Console.WriteLine(result);
        }
    }
}