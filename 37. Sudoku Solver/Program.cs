using System;
using System.Collections.Generic;

namespace _37._Sudoku_Solver
{
    public class Solution
    {
        public void SolveSudoku(char[][] board)
        {
            List<List<char>> rows = new List<List<char>>() { new(), new(), new(), new(), new(), new(), new(), new(), new() };
            List<List<char>> columns = new List<List<char>>() { new(), new(), new(), new(), new(), new(), new(), new(), new() };
            List<List<char>> squares = new List<List<char>>() { new(), new(), new(), new(), new(), new(), new(), new(), new() };

            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    int square = (y / 3)*3 + x/3;  
                    if (board[y][x] != '.')
                    {
                        rows[y].Add(board[y][x]);
                        columns[x].Add(board[y][x]);
                        squares[square].Add(board[y][x]);
                    }
                }
            }
            bool stop = false;
            helper(0, 0);
            Console.WriteLine();

            void helper(int x, int y)
            {
                if (y == 9)
                {
                    stop = true;
                    return;
                }
                int square = (y / 3) * 3 + x / 3;
                int nextX = (x+1) % 9;
                int nextY = y + (x + 1) / 9;
                if (board[y][x] != '.') helper(nextX, nextY);
                else
                {
                for (char i = '1'; i <= '9'; i++)
                {
                    if(!rows[y].Contains(i)&& !columns[x].Contains(i) && !squares[square].Contains(i))
                    {
                        rows[y].Add(i);
                        columns[x].Add(i);
                        squares[square].Add(i);
                        board[y][x] = i;
                        helper(nextX, nextY);
                        if (!stop)
                        {
                            rows[y].Remove(i);
                            columns[x].Remove(i);
                            squares[square].Remove(i);
                            board[y][x] = '.';
                        }
                    }
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
            char[][] board = new char[9][];
            board[0] = new char[9] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            board[1] = new char[9] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            board[2] = new char[9] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
            board[3] = new char[9] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            board[4] = new char[9] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            board[5] = new char[9] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            board[6] = new char[9] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            board[7] = new char[9] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            board[8] = new char[9] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };
            solution.SolveSudoku(board);
        }
    }
}
