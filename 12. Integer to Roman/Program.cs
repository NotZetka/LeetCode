using System;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(1994));
        }
        static Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            {"M",1000},
            {"CM",900},
            {"D",500},
            {"CD",400},
            {"C",100},
            {"XC",90},
            {"L",50},
            {"XL",40},
            {"X",10},
            {"IX",9},
            {"V",5},
            {"IV",4},
            {"I",1}
        };
        public static string IntToRoman(int num)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in dict)
            {
                int counter = num / item.Value;
                for (int i = 0; i < counter; i++)
                {
                    stringBuilder.Append(item.Key);
                }
                num = num % item.Value;
            }
            return stringBuilder.ToString();
        }

    }
}