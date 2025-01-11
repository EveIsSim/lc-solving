namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.IntroductionString;

// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/


public class FindIndexFirstOccurrenceString
{
    public int Solution(string haystack, string needle)
    {
        var m = needle.Length;
        var n = haystack.Length;

        for (var windowStart = 0; windowStart <= n - m; windowStart++)
        {
            for (var i = 0; i < m; i++)
            {
                if (needle[i] != haystack[windowStart + i]) break;

                if (i == m - 1) return windowStart;
            }
        }

        return -1;
    }
}
