namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.Conclusion;

// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/

using EveIsSim.LCSolving.Csharp.Tools.Extensions;

public class FindAllNumbersDisappearedArray
{
    public static void Run()
    {
        var nums = new[] { 4, 3, 2, 7, 8, 2, 3, 1 };
        Solution(nums).PrintArray(); // exp: [5,6]
    }

    public static IList<int> Solution(int[] nums)
    {
        return Enumerable.Range(1, nums.Length).Except(nums).ToList();
    }
}
