namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P01Arrays101.Introduction;

// https://leetcode.com/problems/find-numbers-with-even-number-of-digits/description/

public class FindNumbersWithEvenNumberOfDigits
{
    public static void Run()
    {
        Console.WriteLine(Solution(new[] { 123, 23, 5432, 222, 123444 }));
    }

    public static int Solution(int[] nums)
    {
        var count = 0;

        foreach (var num in nums)
        {
            var numberDigit = (int)Math.Log10(num) + 1;
            if (numberDigit % 2 == 0) count++;
        }

        return count;
    }
}
