using System;
using System.Collections.Generic;

namespace _30._Substring_with_Concatenation_of_All_Words
{
    public class Solution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            List<int> result = new List<int>();
            if(words.Length == 0) return result;
            Dictionary<string, int> wordsDict = new Dictionary<string, int>();
            foreach(string word in words)
            {
                if (wordsDict.ContainsKey(word))
                {
                    wordsDict[word]+=1;
                }
                else
                {
                    wordsDict.Add(word, 1);
                }
            }
            int l = words[0].Length;
            int totalLength = words.Length*l;
            for(int i = 0; i < s.Length-totalLength+1; i++)
            {
                var dictCopy = new Dictionary<string, int>();
                bool add = true;
                foreach (var record in wordsDict)
                {
                    dictCopy[record.Key] = record.Value;
                }
                var substring = s.Substring(i, totalLength);
                for (int j = 0; j < words.Length; j++)
                {
                    var subSubString = substring.Substring(j*l, l);
                    if (!dictCopy.ContainsKey(subSubString))
                    {
                        break;
                    }
                    else
                    {
                        dictCopy[subSubString]-=1;
                    }
                }
                foreach (var record in dictCopy)
                {
                    if (record.Value != 0)
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" });
        }
    }
}
