using EveIsSim.LCSolving.Csharp.Tools.Extensions;

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.DeletingItemsFromArray;

// 1299. Replace Elements with Greatest Element on Right Side

public class ReplaceElementsWithGreatestElementOnRightSide
{
    public static void Run()
    {
        var arr = new[] { 17, 18, 5, 4, 6, 1 };
        Solution(arr).PrintArray();
        //BetterSolution(arr).PrintArray();
    }

    public static int[] Solution(int[] arr)
    {
        if (arr.Length == 1) arr[^1] = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i == arr.Length - 1)
            {
                arr[i] = -1;
                continue;
            }

            var max = arr[i + 1];
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > max) max = arr[j];
            }

            arr[i] = max;
        }

        return arr;
    }

    public static int[] BetterSolution(int[] arr)
    {
        var max = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            var temp = arr[i];
            arr[i] = max;
            if (temp > max) max = temp;
        }

        return arr;
    }
}
