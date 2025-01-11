using System.Text;

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.IntroductionString;

// https://leetcode.com/problems/add-binary/description/

public class AddBinary
{

    // Only for small
    public string Solution1(string a, string b)
    {
        var n1 = Convert.ToInt32(a, 2);
        var n2 = Convert.ToInt32(b, 2);
        var sum = n1 + n2;
        return Convert.ToString(sum, 2);
    }

    public string Solution2(string a, string b)
    {
        var aLen = a.Length;
        var bLen = b.Length;

        if (aLen > bLen)
        {
            b = GetZeros(aLen - bLen) + b;
        }
        else
        {
            a = GetZeros(bLen - aLen) + a;
        }

        var additioanlValue = 0;
        var sb = new StringBuilder();

        for (var i = bLen - 1; i >= 0; i--)
        {
            var res = Convert.ToInt32(a[i].ToString()) + Convert.ToInt32(b[i].ToString()) + additioanlValue;

            if (res >= 2)
            {
                var appVal = res == 3 ? "1" : "0";
                sb.Append(appVal);
                additioanlValue = 1;
            }
            else
            {
                sb.Append(res);
                additioanlValue = 0;
            }
        }

        if (additioanlValue > 0) sb.Append("1");

        var result = sb.ToString();
        return Reverse(result.ToArray());
    }

    string Reverse(char[] s)
    {
        Helper(0, s.Length - 1, s);
        return new string(s);
    }

    void Helper(int f, int l, char[] str)
    {
        if (f >= l) return;
        (str[f], str[l]) = (str[l], str[f]);
        Helper(f + 1, l - 1, str);
    }

    string GetZeros(int val)
    {
        var sb = new StringBuilder();

        while (val > 0)
        {
            sb.Append("0");
            val--;
        }

        return sb.ToString();
    }
}

