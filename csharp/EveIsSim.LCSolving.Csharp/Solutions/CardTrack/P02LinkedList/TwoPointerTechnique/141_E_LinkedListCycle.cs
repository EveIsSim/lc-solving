using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/linked-list-cycle/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.TwoPointerTechnique;

public class LinkedListCycle
{
    public static void Run()
    {
        var nodeCycle = new ListNode(-4);
        var node1 = new ListNode(2, new ListNode(0, nodeCycle));
        var head = new ListNode(3, node1);

        nodeCycle.next = node1;

        Console.WriteLine(Solution(head)); // exp: true. [3, 2, 0, -4(next[1])]
    }

    public static bool Solution(ListNode head)
    {
        if (head is null || head.next == null) return false;

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast) return true;
        }

        return false;
    }
}
