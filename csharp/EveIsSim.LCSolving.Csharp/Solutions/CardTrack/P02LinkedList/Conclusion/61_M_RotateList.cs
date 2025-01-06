using EveIsSim.LCSolving.Csharp.Objects;
using EveIsSim.LCSolving.Csharp.Tools;

// https://leetcode.com/problems/rotate-list/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.Conclusion;

public class RotateList
{
    public static void Run()
    {
        // var l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var l1 = new ListNode(1, new ListNode(2, new ListNode(3)));
        l1.Print();
        var watcher = new Watcher();
        watcher.Start();
        RotateRight(l1, 2_000_000_000).Print();
        Console.WriteLine("cases: 2_000_000_000");
        watcher.Stop();

    }

    public static ListNode RotateRight(ListNode head, int k)
    {
        var iteration = GetIteration(head, k);

        if (head is null || head.next is null) return head;

        var curr = head;
        while (iteration > 0)
        {
            var firstNode = curr;
            var (prev, last) = GetLastNode(firstNode);
            prev.next = null;
            last.next = firstNode;
            curr = last;
            iteration--;
        }

        return curr;
    }

    public static (ListNode prev, ListNode last) GetLastNode(ListNode node)
    {
        var curr = node;
        while (curr.next!.next != null) curr = curr.next;
        return (prev: curr, last: curr.next);
    }

    public static long GetIteration(ListNode head, int k)
    {
        var cntNodes = GetCntNodes(head);
        return k % cntNodes;
    }

    public static long GetCntNodes(ListNode head)
    {
        var cnt = 0;
        var curr = head;
        while (curr != null)
        {
            cnt++;
            curr = curr.next;
        }

        return cnt;
    }
}
