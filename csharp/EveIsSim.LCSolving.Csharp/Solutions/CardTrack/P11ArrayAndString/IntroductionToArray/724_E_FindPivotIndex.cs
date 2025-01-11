// https://leetcode.com/problems/find-pivot-index/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.IntroductionToArray;

public class FindPivotIndex
{
    public static void Run()
    {
        var nums = new[] { 1, 7, 3, 6, 5, 6 };
        Console.WriteLine(Solution(nums));
    }


    public static int Solution(int[] nums)
    {
        var sum = nums.Sum();
        var leftSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (leftSum == sum - leftSum - nums[i]) return i;
            leftSum += nums[i];
        }

        return -1;
    }
}
