namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.Introduction2DArray;

// https://leetcode.com/problems/pascals-triangle/description/

public class PascalTriangle
{
    public IList<IList<int>> Solution(int numRows)
    {
        var result = new List<IList<int>>();
        var edge = 1;

        foreach (var idx in Enumerable.Range(0, numRows))
        {
            var iter = new List<int>();
            if (idx == 0) iter.Add(1);
            else
            {
                var prev = result[idx - 1];

                var firstEdge = edge;
                var lastEdge = edge;

                iter.Add(firstEdge);

                var i = 0;
                while (i < prev.Count - 1)
                {
                    iter.Add(prev[i] + prev[i + 1]);
                    i++;
                }

                iter.Add(lastEdge);
            }

            result.Add(iter);
        }

        return result;
    }
}
