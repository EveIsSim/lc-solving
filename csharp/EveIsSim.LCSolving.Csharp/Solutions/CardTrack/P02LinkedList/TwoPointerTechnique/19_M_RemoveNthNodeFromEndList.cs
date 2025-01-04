using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.TwoPointerTechnique;

public class RemoveNthNodeFromEndList
{
    public static void Run()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))); // 2
        // var head = new ListNode(1); // 1
        var head1 = RemoveNthFromEnd(head, 2);
        head1?.Print();
    }

    public static ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new(0, head); // 0, 1, 2, 3, 4, 5
        ListNode slow = dummy, fast = dummy; // both: 0, 1, 2, 3, 4, 5 

        // Gap of fast and slow is n
        // 0, 1, 2, 3, 4, 5 => 2, 3, 4, 5
        for (int i = 0; i < n; i++)
        {
            fast = fast.next;
        }

        // fast: 2, 3, 4, 5
        //       +  +  +  +  break
        // slow: 0, 1, 2, 3, 4, 5
        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        // slow: 3, 4, 5
        //       +, -, +
        slow.next = slow.next?.next;

        // slow work with link and need return dummy without first custom node.
        return dummy.next;
    }
}
