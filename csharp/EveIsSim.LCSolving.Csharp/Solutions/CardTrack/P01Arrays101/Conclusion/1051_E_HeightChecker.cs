namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.Conclusion;

// https://leetcode.com/problems/height-checker/description/

public class HeightChecker
{
    public static void Run()
    {
        var array1 = new[] { 1, 1, 4, 2, 1, 3 };
        var array2 = new[] { 5, 1, 2, 3, 4 };

        Console.WriteLine(Solution(array1));
    }

    public static int Solution(int[] heights)
    {
        var notEqual = 0;

        if (heights.Length <= 1) return notEqual;

        var expectedArray = heights.OrderBy(x => x).ToArray();

        for (var i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expectedArray[i]) notEqual++;
        }

        return notEqual;
    }

    public static int Solution2(int[] heights)
    {
        var notEqual = 0;

        if (heights.Length <= 1) return notEqual;

        var expectedArray = new int[heights.Length];
        for (var i = 0; i < expectedArray.Length; i++)
        {
            expectedArray[i] = heights[i];
        }

        Array.Sort(expectedArray);

        for (var i = 0; i < heights.Length; i++)
        {
            if (heights[i] != expectedArray[i]) notEqual++;
        }

        return notEqual;
    }
}
