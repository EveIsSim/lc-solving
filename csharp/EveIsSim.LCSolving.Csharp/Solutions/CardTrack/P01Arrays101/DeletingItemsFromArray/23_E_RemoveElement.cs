namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.DeletingItemsFromArray;

// https://leetcode.com/problems/remove-element/description/

public class RemoveElement
{
    public static void Run()
    {
        var nums = new[] { 3, 2, 2, 3 };
        var val = 3;
        Solution(nums, val);
    }

    public static int Solution(int[] nums, int val)
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
