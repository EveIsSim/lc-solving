namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.TwoPointerTechnique;

// https://leetcode.com/problems/remove-element/description/

public class RemoveElement
{
    public int Solution(int[] nums, int val)
    {
        var result = 0;

        foreach (var element in nums)
        {
            if (element != val)
            {
                nums[result] = element;
                result++;
            }
        }

        return result;
    }
}
