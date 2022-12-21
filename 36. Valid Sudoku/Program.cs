using System;
using System.Collections.Generic;

namespace _36._Valid_Sudoku
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<char,List<int[]>> dict = new Dictionary<char, List<int[]>>()
            {
                {'1',new List<int[]>() },
                {'2',new List<int[]>() },
                {'3',new List<int[]>() },
                {'4',new List<int[]>() },
                {'5',new List<int[]>() },
                {'6',new List<int[]>() },
                {'7',new List<int[]>() },
                {'8',new List<int[]>() },
                {'9',new List<int[]>() }
            };
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                { 
                    if (board[x][y] != '.')
                    {
                        int[] current = new int[] { x, y, 10 * (x / 3) + (y / 3) };
                        foreach (var point in dict[board[x][y]])
                        {
                            if (current[0] == point[0] ||
                                current[1] == point[1] ||
                                current[2] == point[2]) return false;
                        }
                        dict[board[x][y]].Add(current);
                    }
                }
            }
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
