// https://leetcode.com/problems/plus-one/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.IntroductionToArray;

public class PlusOne
{
    public static void Run()
    {
        var test = new[] { 0 };
        var result = Solution(test);
    }

    public static int[] Solution(int[] digits)
    {
        var remaining = 1;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (remaining == 0) return digits;

            var mid = digits[i] + remaining;
            if (mid < 10)
            {
                digits[i] = mid;
                remaining = 0;
            }
            else
            {
                digits[i] = mid - 10;
            }
        }

        if (remaining == 1)
        {
            var result = new List<int> { remaining };
            result.AddRange(digits);
            return result.ToArray();
        }

        return digits;
    }
}
