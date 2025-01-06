using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/remove-linked-list-elements/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.ClassicProblems;

public class RemoveLinkedListElements
{
    public static void Run()
    {
        // var start = new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
        var start = new ListNode(1, new ListNode(2, new ListNode(3)));
        Solution(start, 6)?.Print();

    }

    public static ListNode? Solution(ListNode head, int val)
    {
        if (head is null) return null;

        var dummy = new ListNode(-1, head);
        var curr = dummy;

        while (curr.next is not null)
        {
            if (curr.next.val == val)
            {
                curr.next = curr.next.next;
            }
            else
            {
                curr = curr.next;
            }
        }

        return dummy.next;
    }
}
