using System.Text;

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.IntroductionString;

// https://leetcode.com/problems/longest-common-prefix/description/


public static class LongestCommonPrefix
{
    public static void Run()
    {
        // To verify
        var strs = new[] { "flower", "flow", "flight" }; // output: "fl"
        var strs2 = new[] { "dog", "racecar", "car" };
        var strs3 = new[] { "ab", "a" };
        var result = LongestCommonPrefix.Solution(["flower", "flow", "flight"]);

        Console.WriteLine(Solution(strs3));

    }

    public static string Solution(string[] strs)
    {
        if (strs is null || strs.Length == 0) return "";
        if (strs.Length == 1) return strs.First();

        var sb = new StringBuilder();
        var minWord = strs.MinBy(x => x.Length);
        var minLength = minWord.Length;
        var lengthArray = strs.Length;

        for (var i = 0; i < minLength; i++)
        {
            var curVal = minWord[i];
            var checkComparer = strs.Where(x => x[i] == curVal).ToArray();
            if (checkComparer.Length == lengthArray)
            {
                sb.Append(curVal);
                continue;
            }

            break;
        }

        return sb.ToString();
    }
}
