using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/reverse-linked-list/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.ClassicProblems;


public class ReverseLinkedList
{
    public static void Run()
    {
        // var start = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var start = new ListNode(1, new ListNode(2, new ListNode(3)));
        Solution(start).Print();

        // 1. [] -> []
        // 2. [1] -> [1]
        // 3. [1, 2] -> [2, 1]
        //    [1, 2, 3] -> [3, 2, 1]
        //    etc.
    }

    public static ListNode Solution(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            var nxt = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nxt;
        }

        return prev;
    }

    ListNode Solution2(ListNode head)
    {
        // recursive

        if (head is null || head.next is null) return head;

        ListNode reversedSubList = Solution2(head.next);
        head.next.next = head;
        head.next = null;

        return reversedSubList;
    }

}
