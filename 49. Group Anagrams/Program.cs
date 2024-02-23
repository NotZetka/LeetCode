using System;

namespace _49._Group_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var result = solution.GroupAnagrams(strs);
            Console.WriteLine();
        }
    }
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            foreach (var item in strs)
            {
                var anagram = String.Concat(item.OrderBy(x => x));
                if (dict.ContainsKey(anagram))
                {
                    dict[anagram].Add(item);
                }
                else
                {
                    dict[anagram] = new List<string> { item };
                }
            }
            return dict.Values.ToList();
        }
    }
}