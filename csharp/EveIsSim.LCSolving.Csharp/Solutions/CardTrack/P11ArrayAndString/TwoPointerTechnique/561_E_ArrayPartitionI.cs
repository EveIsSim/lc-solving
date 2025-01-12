namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.TwoPointerTechnique;

// https://leetcode.com/problems/array-partition/description/


public class ArrayPartition
{
    public int Solution(int[] nums)
    {
        Array.Sort(nums);

        var result = 0;
        for (var i = 0; i < nums.Length; i += 2)
        {
            result += nums[i];
        }

        return result;
    }
}
