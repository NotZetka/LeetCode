using System;
using System.Collections.Generic;
using System.Linq;

namespace _40._Combination_Sum_II
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> results = new List<IList<int>>();
            Array.Sort(candidates);
            helper(new List<int>(), 0, 0);
            void helper(IList<int> list, int sum, int start)
            {
                if (sum == target)
                {
                    var result = list.Select(x => x).ToList();
                    results.Add(result);
                }
                else if (sum < target)
                {
                    for (int i = start; i < candidates.Length; i++)
                    {
                        var item = candidates[i];
                        if (sum + item <= target)
                        {
                            list.Add(item);
                            helper(list, sum + item, i + 1);
                            list.Remove(item);
                        }
                        while(i+1< candidates.Length && candidates[i] == candidates[i + 1])
                        {
                            i++;
                        }
                    }
                }
            }
            return results;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.CombinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
        }
    }
}
