namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.TwoPointerTechnique;

// https://leetcode.com/problems/max-consecutive-ones/description/

public class MaxConsecutiveOnes
{
    public static void Run()
    {
        var check = new[] { 1, 1, 0, 1, 1, 1 };

        Console.WriteLine(Solution(check));
    }

    public static int Solution(int[] nums)
    {
        var max = 0;
        var current = 0;

        foreach (var num in nums)
        {
            if (num == 1) current++;
            if (current > max) max = current;
            if (num == 0) current = 0;
        }

        return max;
    }
}
