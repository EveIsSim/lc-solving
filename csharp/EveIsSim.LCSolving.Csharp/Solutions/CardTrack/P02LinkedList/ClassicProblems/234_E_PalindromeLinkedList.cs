using System.Collections;
using System.Text;
using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/palindrome-linked-list/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.ClassicProblems;


public class PalindromeLinkedList
{
    public static void Run()
    {
        // var start = new ListNode(1, new ListNode(2, new ListNode(1)));
        // var start = new ListNode(1, new ListNode(2));
        // var start = new ListNode(1, new ListNode(2, new ListNode(3)));
        // var start = new ListNode(1, new ListNode(0, new ListNode(3, new ListNode(5, new ListNode(0, new ListNode(1))))));
        var start1 = new ListNode(4, new ListNode(8, new ListNode(8, new ListNode(5, new ListNode(8, new ListNode(9, new ListNode(8, new ListNode(5, new ListNode(8, new ListNode(8, new ListNode(4)))))))))));
        //[4,8,8,5,8,9,8,5,8,8,4]
        var gg = Solution2(start1);
        Console.WriteLine(gg);

    }

    public static bool Solution(ListNode head)
    {
        var current = head;

        var sb = new StringBuilder();

        while (current != null)
        {
            sb.Append(current.val);
            current = current.next;
        }

        var value = sb.ToString();
        var reverseValue = new string(value.Reverse().ToArray());

        return value == reverseValue;
    }

    public static bool Solution2(ListNode head)
    {
        var reverseNode = new Stack();
        var straightNode = new Queue();
        var current = head;

        while (current != null)
        {
            reverseNode.Push(current.val);
            straightNode.Enqueue(current.val);
            current = current.next;
        }

        while (reverseNode.Count > 0)
        {
            if (reverseNode.Peek().Equals(straightNode.Peek()))
            {
                reverseNode.Pop();
                straightNode.Dequeue();
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
