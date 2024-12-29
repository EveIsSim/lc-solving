namespace EveIsSim.LCSolving.Csharp.Objects;

public class ListNodeChild
{
    public int val;
    public ListNodeChild? prev;
    public ListNodeChild? next;
    public ListNodeChild? child;

    public ListNodeChild(
        int val = 0, 
        ListNodeChild? prev = null, 
        ListNodeChild? next = null,
        ListNodeChild? child = null)
    {
        this.val = val;
        this.prev = prev;
        this.next = next;
        this.child = child;
    }

    public void PrintWithoutChild()
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
