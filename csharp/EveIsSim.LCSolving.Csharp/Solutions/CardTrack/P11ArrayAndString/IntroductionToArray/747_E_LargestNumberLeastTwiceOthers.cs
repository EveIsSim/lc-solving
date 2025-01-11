// https://leetcode.com/problems/largest-number-at-least-twice-of-others/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.IntroductionToArray;

public class LargestNumberLeastTwiceOthers
{
    public int Solution(int[] nums)
    {
        var maxVal = nums.Max();
        if (nums.Any(val => val != maxVal && val * 2 > maxVal)) return -1;

        return Array.IndexOf(nums, maxVal);
    }
}
