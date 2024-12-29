namespace EveIsSim.LCSolving.Csharp.Tools.Extensions;

public static class ArrayExtensions
{
    public static void PrintArray<T>(this IEnumerable<T> array)
    {
        Console.Write("[");
        var response = string.Join(", ", array);
        Console.Write(response);
        Console.WriteLine("]");
    }

    public static void PrintArray(this string[] array)
    {
        Console.Write("[");
        var response = string.Join(", ", array);
        Console.Write(response);
        Console.WriteLine("]");
    }

}

