using System.Runtime.CompilerServices;

namespace _46._Permutations
{
    public class Solution
    {
        IList<IList<int>> result;
        public IList<IList<int>> Permute(int[] nums)
        {
            result = new List<IList<int>>();
            if (nums.Length == 0) { return result; }
            Array.Sort(nums);
            List<int> list = new List<int>() { nums[0] };
            Helper(list, nums, 1);
            return result;
        }
        private void Helper(List<int> list, int[] nums, int count)
        {
            if (nums.Length == list.Count)
            {
                result.Add(list.Select(x => x).ToList());
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] != nums[count])
                    {
                        list.Insert(i, nums[count]);
                        Helper(list, nums, count + 1);
                        list.RemoveAt(i);
                    }
                }
                list.Add(nums[count]);
                Helper(list, nums, count + 1);
                list.RemoveAt(count);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.Permute(new int[]{
                1,2,3
            });
        }
    }
}