namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.DeletingItemsFromArray;

// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/

public class RemoveDuplicatesFromSortedArray
{
    public static void Run()
    {
        var a = Solution(new[] { 1, 2, 2 });
        Console.WriteLine(a);
    }

    public static int Solution(int[] nums)
    {
        int i = 1;

        foreach (var n in nums)
        {
            if (nums[i - 1] != n) nums[i++] = n;
        }

        return i;
    }
}
