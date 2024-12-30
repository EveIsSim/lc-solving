using EveIsSim.LCSolving.Csharp.Tools.Extensions;

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.InsertingItemsArray;

// https://leetcode.com/problems/duplicate-zeros/description/

public class DuplicateZeros
{

    public static void Run()
    {
        var arr = new[] { 1, 0, 2, 3, 0, 4, 5, 0 };
        Solution1(arr);
        //Solution2(arr);

        arr.PrintArray(); // exp: [1,0,0,2,3,0,0,4]
    }

    public static void Solution1(int[] arr)
    {
        var temp = new int[arr.Length * 2];
        var tempIdx = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                temp[tempIdx] = 0;
                temp[tempIdx + 1] = 0;
                tempIdx += 2;
            }
            else
            {
                temp[tempIdx] = arr[i];
                tempIdx++;
            }
        }

        Array.Copy(temp, arr, arr.Length);
    }

    public static void Solution2(int[] arr)
    {
        int len = arr.Length;
        var temp = new int[len];

        for (int i = 0, j = 0; j < len; j++, i++)
        {
            temp[j] = arr[i];
            if (temp[j] == 0 && j < len - 1)
            {
                temp[j + 1] = 0;
                j++;
            }
        }

        Array.Copy(temp, arr, len);
    }
}
