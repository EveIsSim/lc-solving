namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.Conclusion;

// https://leetcode.com/problems/third-maximum-number/description/

public class ThirdMaximumNumber
{
    public static void Run()
    {
        var array1 = new[] { 1, 2 };
        var array2 = new[] { 3, 2, 1 };
        var array3 = new[] { 5, 2, 2 };
        var array4 = new[] { 2, 2, 3, 1 };
        var array5 = new[] { 1, 2, 2, 5, 3, 5 };

        Console.WriteLine(Solution(array5));
    }

    public static int Solution(int[] nums)
    {
        var length = nums.Length;

        if (length <= 1) return nums[0];
        if (length < 3) return nums.Max();

        Array.Sort(nums);
        Array.Reverse(nums);

        var idx = 1;
        foreach (var value in nums)
        {
            if (nums[idx - 1] != value) nums[idx++] = value;
        }

        var countMaximum = 3;
        for (var i = 0; i < countMaximum; i++)
        {
            var repeated = -1;
            for (var j = 0; j < countMaximum; j++)
            {
                if (nums[i] == nums[j]) repeated++;
            }

            if (repeated > 0) return nums.Max();
        }

        return nums[2];
    }
}
