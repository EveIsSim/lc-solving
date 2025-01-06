using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/odd-even-linked-list/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.ClassicProblems;


public class OddEvenLinkedList
{
    public static void Run()
    {
        // var start = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var start = new ListNode(1, new ListNode(2, new ListNode(3)));
        Solution(start)?.Print();
    }

    public static ListNode? Solution(ListNode head)
    {
        var curr = head;

        var evenNodes = new ListNode(0);
        var evenDummy = evenNodes;

        var oddNodes = new ListNode(0);
        var oddDummy = oddNodes;

        var counter = 1;

        while (curr != null)
        {
            if (counter % 2 == 0)
            {
                evenDummy.next = curr;
                evenDummy = evenDummy.next;
            }
            else
            {
                oddDummy.next = curr;
                oddDummy = oddDummy.next;
                if (curr.next is null) evenDummy.next = null;
            }

            counter++;
            curr = curr.next;
        }

        var result = oddNodes.next;
        var searchable = result;

        while (searchable.next != null)
        {
            searchable = searchable.next;
        }

        searchable.next = evenNodes.next;
        return result;
    }

    public ListNode? Solution2(ListNode head)
    {
        if (head == null) return null;
        var odd = head;
        var even = head.next;
        var evenHead = even;

        while (even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }

        odd.next = evenHead;
        return head;
    }
}
