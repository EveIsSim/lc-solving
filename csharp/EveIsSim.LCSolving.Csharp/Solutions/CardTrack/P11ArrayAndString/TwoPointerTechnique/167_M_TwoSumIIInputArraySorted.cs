namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P11ArrayAndString.TwoPointerTechnique;

// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/

public class TwoSumIIInputArraySorted
{
    public int[] Solution(int[] numbers, int target)
    {
        var low = 0;
        var high = numbers.Length - 1;

        while (low < high)
        {
            var sum = numbers[low] + numbers[high];
            if (sum == target) return [low + 1, high + 1];

            if (sum < target) ++low;
            else --high;
        }

        return [-1, -1];
    }
}
