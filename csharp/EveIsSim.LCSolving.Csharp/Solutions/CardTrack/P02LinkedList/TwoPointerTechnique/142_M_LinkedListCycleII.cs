using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/linked-list-cycle-ii/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.TwoPointerTechnique;


public class LinkedListCycleII
{
    public static ListNode Solution(ListNode head)
    {
        if (head is null) return null;

        var slow = head;
        var fast = head;

        while (fast.next is not null && fast.next.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast) break;
        }

        if (fast.next is null || fast.next.next is null) return null;

        var slow2 = head;
        while (slow.next is not null)
        {
            if (slow == slow2) return slow;
            slow = slow.next;
            slow2 = slow2.next;
        }

        return null;
    }
}
