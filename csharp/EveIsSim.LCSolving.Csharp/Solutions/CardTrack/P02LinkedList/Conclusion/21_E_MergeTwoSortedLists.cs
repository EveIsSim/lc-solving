using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/merge-two-sorted-lists/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.Conclusion;

public class MergeTwoSortedLists
{
    public static void Run()
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var a = Solution(list1, list2);

        while (a.next != null)
        {
            Console.WriteLine(a.val);
            a = a.next;
        }
    }

    public static ListNode Solution(ListNode list1, ListNode list2)
    {
        var resultMergeList = new ListNode();
        var tail = resultMergeList;
        var currentNode1 = list1;
        var currentNode2 = list2;

        while (currentNode1 != null && currentNode2 != null)
        {
            if (currentNode1.val < currentNode2.val)
            {
                tail.next = currentNode1;
                currentNode1 = currentNode1.next;
            }
            else
            {
                tail.next = currentNode2;
                currentNode2 = currentNode2.next;
            }

            tail = tail.next;
        }

        tail.next = currentNode1 ?? currentNode2;

        return resultMergeList.next!;
    }

    public static ListNode Solution2(ListNode list1, ListNode list2)
    {
        // recursion
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        if (list1.val < list2.val)
        {
            list1.next = Solution2(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = Solution2(list1, list2.next);
            return list2;
        }
    }
}
