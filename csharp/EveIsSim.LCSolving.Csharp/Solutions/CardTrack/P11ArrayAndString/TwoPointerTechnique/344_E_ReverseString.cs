using System.Text.Json;

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.TwoPointerTechnique;

// https://leetcode.com/problems/reverse-string/description/

public class ReverseString
{
    public static void Run()
    {
        var s = "!nerdlihc".ToArray();
        Console.WriteLine(JsonSerializer.Serialize(s));
        Solution(s);
        Console.WriteLine(JsonSerializer.Serialize(s));

    }

    public static void Solution(char[] s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }
    }

    public void Solution2(char[] s)
    {
        Helper(0, s.Length - 1, s);
    }

    public void Helper(int f, int l, char[] str)
    {
        if (f >= l) return;
        (str[f], str[l]) = (str[l], str[f]);
        Helper(f++, l--, str);
    }
}
