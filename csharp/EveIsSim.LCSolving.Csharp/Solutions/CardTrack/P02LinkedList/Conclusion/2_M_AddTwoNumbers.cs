using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/add-two-numbers/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.Conclusion;


public class AddTwoNumbers
{
    public static void Run()
    {
        var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        l1.Print();
        var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        l2.Print();
        var itog = Solution(l1, l2);
        itog.Print();
    }

    public static ListNode Solution(ListNode l1, ListNode l2)
    {
        var resultList = new ListNode();
        ListNode prev = null;
        var tail = resultList;

        var firstNode = l1;
        var secondNode = l2;

        var incrementValue = false;
        while (firstNode != null && secondNode != null)
        {
            var temporaryValue = firstNode.val + secondNode.val;
            var currentValue = incrementValue ? temporaryValue + 1 : temporaryValue + 0;
            incrementValue = currentValue >= 10;
            var remainder = incrementValue ? currentValue % 10 : currentValue;


            tail.next = new ListNode(remainder);
            firstNode = firstNode.next;
            secondNode = secondNode.next;

            tail = tail.next;
        }

        var remainderNode = firstNode ?? secondNode;

        while (remainderNode != null)
        {
            var currentValue = incrementValue ? remainderNode.val + 1 : remainderNode.val + 0;
            incrementValue = currentValue >= 10;
            var remainder = incrementValue ? currentValue % 10 : currentValue;

            tail.next = new ListNode(remainder);
            remainderNode = remainderNode.next;
            tail = tail.next;
        }

        if (incrementValue && remainderNode is null) tail.next = new ListNode(1);

        return resultList.next!;
    }
}
