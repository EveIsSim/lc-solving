namespace EveIsSim.LCSolving.Csharp.Objects;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public void Print()
    {
        Console.Write($"[{val}");
        if (next is not null) Console.Write(", ");

        var currentNode = next;
        while (currentNode is not null)
        {
            Console.Write($"{currentNode.val}");
            currentNode = currentNode.next;

            if (currentNode is not null) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}
