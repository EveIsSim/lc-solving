using EveIsSim.LCSolving.Csharp.Tools.Extensions;

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.Conclusion;

// https://leetcode.com/problems/squares-of-a-sorted-array/description/


public class SquaresSortedArray
{
    public static void Run()
    {
        var nums = new[] { -4, -1, 0, 3, 10 };
        Solution(nums).PrintArray();
    }

    public static int[] Solution(int[] nums)
    {
        // return nums.Select(x => x * x).OrderBy(x => x).ToArray();

        var result = nums;
        for (var i = 0; i < result.Length; i++)
        {
            result[i] *= result[i];
        }
        Array.Sort(result);
        return result;
    }
}
