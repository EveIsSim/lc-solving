using EveIsSim.LCSolving.Csharp.Tools.Extensions;

// https://leetcode.com/problems/sort-array-by-parity/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.DeletingItemsFromArray;


public class SortArrayByParity
{
    public static void Run()
    {
        var array1 = new[] { 3, 1, 2, 4 };
        array1.PrintArray();
    }
    public static int[] Solution(int[] nums)
    {
        if (nums.Length <= 1) return nums;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0) continue;

            var isChange = false;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (isChange) break;

                if (nums[j] % 2 == 0)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                    isChange = true;
                }
            }
        }

        return nums;
    }

    public static int[] FasterSolution(int[] nums)
    {
        var j = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                (nums[j], nums[i]) = (nums[i], nums[j]);
                j++;
            }
        }

        return nums;
    }
}
