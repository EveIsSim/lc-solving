namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.Conclusion;

// https://leetcode.com/problems/max-consecutive-ones-ii/description/

public class MaxConsecutiveOnesII
{
    public static void Run()
    {
        var a = new[] { 1, 0, 1, 1, 0, 1, 1, 1 };

        var result = Solution(a);
        Console.WriteLine(result);
    }

    public static int Solution(int[] nums)
    {
        var max = 0;
        var curIdx = 0;
        var localMax = 0;
        var flipZero = false;
        var goOn = true;

        while (goOn)
        {
            var isBreak = false;
            for (var i = curIdx; i < nums.Length; i++)
            {
                if (nums[i] == 0 && flipZero)
                {
                    flipZero = false;
                    isBreak = true;
                    break;
                }

                if (nums[i] == 0 && !flipZero)
                {
                    curIdx = i + 1;
                    flipZero = true;
                }

                localMax++;
            }

            if (localMax > max) max = localMax;
            localMax = 0;
            if (!isBreak) goOn = false;
        }

        return max;
    }
}
