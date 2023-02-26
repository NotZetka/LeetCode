using System;

namespace _48._Rotate_Image
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int len = matrix.Length;
            for (int j = 0; j < len/2; j++)
            {
                for (int i = j; i < len-j-1; i++)
                {
                    var temp = matrix[i][len - 1 - j];
                    matrix[i][len-1-j] = matrix[j][i];
                    matrix[j][i] = matrix[len - 1 -i][j];
                    matrix[len - 1 - i][j] = matrix[len-1-j][len-1-i];
                    matrix[len - 1 - j][len - 1 - i] = temp;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] matrix = new int[3][];
            //matrix[0]=new int[] {1,2,3};
            //matrix[1]=new int[] {4,5,6};
            //matrix[2]=new int[] {7,8,9};
            int[][] matrix = new int[4][];
            matrix[0] = new int[] {5,1,9,11 };
            matrix[1] = new int[] {2,4,8,10 };
            matrix[2] = new int[] {13,3,6,7 };
            matrix[3] = new int[] {15,14,12,16 };
            Solution solution = new Solution();
            solution.Rotate(matrix);
        }
    }
}
