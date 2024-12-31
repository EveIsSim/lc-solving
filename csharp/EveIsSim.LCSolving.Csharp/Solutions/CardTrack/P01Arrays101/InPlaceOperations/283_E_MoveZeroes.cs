using EveIsSim.LCSolving.Csharp.Tools.Extensions;

// https://leetcode.com/problems/move-zeroes/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.DeletingItemsFromArray;

public class MoveZeroes
{
    public static void Run()
    {
        var array1 = new[] { 0, 1, 0, 3, 12 }; // Output: [1, 3, 12, 0, 0]
        var array2 = new[] { 0 }; // Output: [0]

        array1.PrintArray();
        Solution(array1);
        array1.PrintArray();

        //array2.PrintArray();
        //MoveZeroes(array2);
        //array2.PrintArray();
    }
    public static void Solution(int[] nums)
    {
        if (nums.Length <= 1) return;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                var isChange = false;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (isChange) break;

                    if (nums[j] != 0)
                    {
                        (nums[i], nums[j]) = (nums[j], nums[i]);
                        isChange = true;
                    }
                }
            }
        }
    }

    // More faster
    public static void Solution2(int[] nums)
    {
        int l = 0, r = 0;
        foreach (int num in nums)
        {
            if (num == 0)
            {
                r++;
                continue;
            }

            nums[l + r] = 0;
            nums[l++] = num;
        }
    }
}
