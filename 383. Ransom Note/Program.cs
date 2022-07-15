using System;

namespace MyApp 
{

    internal class Program
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            int[] ransomChares = new int[128];
            int lenght = ransomNote.Length;
            foreach (char Char in ransomNote)
            {
                ransomChares[Char]++;
            }
            foreach (char Char in magazine)
            {
                if (ransomChares[Char] > 0)
                {
                    ransomChares[Char]--;
                    lenght--;
                }
                if(lenght == 0) { return true; }
            }
            return false;
            /*
            var ransomArray = ransomNote.ToArray();
            var magazineArray = magazine.ToArray();
            Array.Sort(ransomArray);
            Array.Sort(magazineArray);
            int j = 0;
            for (int i = 0; i < ransomArray.Length; i++, j++)
            {
                if (j >= magazineArray.Length) return false;
                while (magazineArray[j] != ransomArray[i])
                {
                    j++;
                    if (j >= magazineArray.Length) return false;
                }
            }
            return true;
            */
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct("a","ba"));
        }
    }
}