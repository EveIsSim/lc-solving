// https://leetcode.com/problems/copy-list-with-random-pointer/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.Conclusion;

public class CopyListwithRandomPointer
{
    public static Node CopyRandomList(Node head)
    {
        if (head is null) return null;

        var oldToNew = new Dictionary<Node, Node>();

        var curr = head;
        while (curr != null)
        {
            oldToNew[curr] = new Node(curr.val);
            curr = curr.next;
        }

        curr = head;
        while (curr != null)
        {
            oldToNew[curr].next = curr.next != null ? oldToNew[curr.next] : null;
            oldToNew[curr].random = curr.random != null ? oldToNew[curr.random] : null;
            curr = curr.next;
        }

        return oldToNew[head];
    }
}


public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}
