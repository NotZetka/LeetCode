using System;
using System.Collections.Generic;
using System.Linq;

namespace _39._Combination_Sum
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> results = new List<IList<int>>();
            helper(new List<int>(), 0,0);
            void helper(IList<int> list, int sum, int start)
            {
                if(sum == target)
                {
                    var result = list.Select(x => x).ToList();
                    results.Add(result);
                }else if (sum < target)
                {
                    for(int i = start; i<candidates.Length; i++)
                    {
                        var item = candidates[i];
                        if (sum + item <= target)
                        {
                            list.Add(item);
                            helper(list, sum+item, i);
                            list.Remove(item);
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
            solution.CombinationSum(new[] { 2, 3, 5 }, 8);
        }
    }
}
