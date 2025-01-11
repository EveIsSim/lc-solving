namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.Introduction2DArray;

// https://leetcode.com/problems/spiral-matrix/description/

public class SpiralMatrix
{
    public IList<int> Solution(int[][] matrix)
    {
        var result = new List<int>();
        var rows = matrix.Length;
        var columns = matrix[0].Length;
        var up = 0;
        var left = 0;
        var right = columns - 1;
        var down = rows - 1;

        while (result.Count < rows * columns)
        {
            // Traverse from left to right.
            for (int col = left; col <= right; col++)
            {
                result.Add(matrix[up][col]);
            }

            // Traverse downwards.
            for (int row = up + 1; row <= down; row++)
            {
                result.Add(matrix[row][right]);
            }

            // Make sure we are now on a different row.
            if (up != down)
            {
                // Traverse from right to left.
                for (int col = right - 1; col >= left; col--)
                {
                    result.Add(matrix[down][col]);
                }
            }

            // Make sure we are now on a different column.
            if (left != right)
            {
                // Traverse upwards.
                for (int row = down - 1; row > up; row--)
                {
                    result.Add(matrix[row][left]);
                }
            }

            left++;
            right--;
            up++;
            down--;
        }

        return result;
    }
}

