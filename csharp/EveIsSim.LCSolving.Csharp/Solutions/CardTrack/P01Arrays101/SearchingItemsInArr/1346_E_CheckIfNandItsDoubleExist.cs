namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.SearchingItemsInArr;

// https://leetcode.com/problems/check-if-n-and-its-double-exist/description/

public class CheckIfNAndItsDoubleExist
{
    public static void Run()
    {
        var arr = new[] { 10, 2, 5, 3 }; // true
        //var arr = new[] { 3, 1, 7, 11 }; // false

        Console.WriteLine(Solution(arr));
    }

    public static bool Solution(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i == j) continue;
                if (arr[i] == 2 * arr[j]) return true;
            }
        }

        return false;
    }
}
