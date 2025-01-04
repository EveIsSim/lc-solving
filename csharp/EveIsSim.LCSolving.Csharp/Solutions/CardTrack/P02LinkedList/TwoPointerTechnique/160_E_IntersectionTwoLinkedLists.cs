using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/intersection-of-two-linked-lists/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.TwoPointerTechnique;

public class IntersectionTwoLinkedLists
{
    public ListNode Solution(ListNode headA, ListNode headB)
    {
        var hashSet = new HashSet<ListNode>();

        if (headA == headB) return headA;

        var a = headA;

        while (a != null)
        {
            hashSet.Add(a);
            a = a.next;
        }

        var b = headB;

        while (b != null)
        {
            if (hashSet.Contains(b)) return b;
            b = b.next;
        }

        return null;
    }
}
