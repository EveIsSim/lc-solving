namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.SearchingItemsInArr;

// https://leetcode.com/problems/valid-mountain-array/description/

public class ValidMountainArray
{
    public static void Run()
    {
        var arr = new[] { 2, 1 }; // false
        //var arr = new[] { 3, 5, 5 }; // false
        //var arr = new[] { 0, 3, 2, 1 }; // true

        //var arr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // true

        Console.WriteLine(Solution(arr));
    }

    public static bool Solution(int[] arr)
    {
        if (arr.Length < 3) return false;
        if (arr[0] > arr[1]) return false;

        var result = true;
        var current = arr[0];
        var hasTop = false;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == current) return false;
            if (!hasTop && arr[i] < current) hasTop = true;

            if (!hasTop && arr[i] > current)
            {
                current = arr[i];
            }
            else if (hasTop && arr[i] < current)
            {
                current = arr[i];
            }
            else result = false;
        }

        if (hasTop && result) return true;
        return false;
    }
}
