using System;
using System.Collections.Generic;
using System.Linq;

namespace _47._Permutations_II
{
    public class Solution
    {
        IList<IList<int>> result;
        int length;
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            result = new List<IList<int>>();
            length = nums.Length;
            if (length == 0) { return result; }
            Array.Sort(nums);
            var numsDict = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (numsDict.ContainsKey(i))
                {
                    numsDict[i]++;
                }
                else { numsDict.Add(i, 1); }
            }
            helper(new(), numsDict);
            return result;
        }
        private void helper(List<int> list, Dictionary<int, int> numsDict)
        {
            if(list.Count == length)
            {
                result.Add(list.Select(x => x).ToList());
            }
            else
            {
                foreach ((int key,int value) in numsDict)
                {
                    if (value > 0)
                    {
                        numsDict[key]--;
                        list.Add(key);
                        helper(list, numsDict);
                        numsDict[key]++;
                        list.RemoveAt(list.Count - 1);
                    }
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.PermuteUnique(new[] { 1, 2, 3 });
        }
    }
}
