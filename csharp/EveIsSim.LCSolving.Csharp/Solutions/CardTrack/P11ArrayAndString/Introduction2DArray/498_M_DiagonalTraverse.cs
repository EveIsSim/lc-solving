namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.Introduction2DArray;

// https://leetcode.com/problems/diagonal-traverse/description/

public class DiagonalTraverse
{
    public static void Run()
    {
        var test = new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
        var result = Solution(test);

    }

    public static int[] Solution(int[][] matrix)
    {
        if (matrix is null || matrix.Length == 0) return [0];

        var N = matrix.Length;
        var M = matrix[0].Length;

        var result = new int[N * M];
        var k = 0;
        var intermediate = new List<int>();

        for (var d = 0; d < N + M - 1; d++)
        {

            intermediate.Clear();

            var r = d < M ? 0 : d - M + 1;
            var c = d < M ? d : M - 1;

            while (r < N && c > -1)
            {

                intermediate.Add(matrix[r][c]);
                ++r;
                --c;
            }

            if (d % 2 == 0)
            {
                intermediate.Reverse();
            }

            for (var i = 0; i < intermediate.Count; i++)
            {
                result[k++] = intermediate[i];
            }
        }
        return result;
    }
}
