using EveIsSim.LCSolving.Csharp.Tools.Extensions;

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.InsertingItemsArray;

// https://leetcode.com/problems/merge-sorted-array/description/

public class MergeSortedArray
{
    public static void Run()
    {
        var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
        var m = 3;
        var nums2 = new[] { 2, 5, 6 };
        var n = 3;

        Solution1(nums1, m, nums2, n);
        //Solution2(nums1, m, nums2, n);

        nums1.PrintArray(); // exp: [1,2,2,3,5,6]
    }


    public static void Solution1(int[] nums1, int m, int[] nums2, int n)
    {
        var first = nums1.Take(m).ToArray();
        var second = nums2.Take(n).ToArray();
        var result = first.Concat(second).OrderBy(x => x).ToArray();

        Array.Copy(result, nums1, result.Length);
    }

    public static void Solution2(int[] nums1, int m, int[] nums2, int n)
    {
        Array.Copy(nums2, 0, nums1, m, n);
        Array.Sort(nums1);
    }
}
