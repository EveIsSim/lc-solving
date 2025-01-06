using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.Conclusion;

public class FlattenMultilevelDoublyLinkedList
{
    public static ListNodeChild Solution(ListNodeChild head)
    {
        var current = head;

        while (current != null)
        {
            if (current.child != null)
            {
                var nxt = current.next;
                current.next = current.child;
                current.child.prev = current;
                current.child = null;
                var lastNodeChild = GetLastChildNode(current.next);
                if (nxt != null)
                {
                    lastNodeChild.next = nxt;
                    nxt.prev = lastNodeChild;
                }
            }

            current = current.next;
        }

        return head;
    }

    public static ListNodeChild GetLastChildNode(ListNodeChild childNode)
    {
        while (childNode.next != null) childNode = childNode.next;
        return childNode;
    }

    // ================ Solution 2 =====================

    private readonly Stack<ListNodeChild> _stack = new();

    public ListNodeChild Solution2(ListNodeChild head)
    {
        return Flatten(head, null);
    }

    public ListNodeChild Flatten(ListNodeChild node, ListNodeChild prev)
    {
        if (node == null)
        {
            return _stack.TryPop(out var nextNode)
                ? Flatten(nextNode, prev)
                : null;
        }

        if (node.child == null)
        {
            node.next = Flatten(node.next, node);
            node.prev = prev;
            return node;
        }

        // With child
        if (node.next != null)
            _stack.Push(node.next);

        node.next = Flatten(node.child, node);
        node.child = null;
        node.prev = prev;
        return node;
    }
}
