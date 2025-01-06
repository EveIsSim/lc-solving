using EveIsSim.LCSolving.Csharp.Objects;

// https://leetcode.com/problems/design-linked-list/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.DoublyLinkedList;

public class MyLinkedList
{
    public Node? Head { get; set; }

    public int Get(int index)
    {
        if (Head is null) return -1;
        var currentNode = Head;

        while (index != 0)
        {
            if (currentNode.right is null) return -1;
            currentNode = currentNode?.next;
            index--;
        }

        return currentNode!.val;
    }

    public void AddAtHead(int val)
    {
        if (Head is null)
        {
            Head = new Node(val, null, null);
            return;
        }

        Head = new Node(val, null, Head);
        Head!.next!.left = Head;
    }

    public void AddAtTail(int val)
    {
        if (Head is null)
        {
            AddAtHead(val);
            return;
        }

        var currentNode = Head;
        while (currentNode?.right != null) currentNode = currentNode?.right;

        currentNode!.right = new Node(val, currentNode, null);
    }

    public void AddAtIndex(int index, int val)
    {
        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        var curentNode = Head;

        while (index != 0)
        {
            if (curentNode is null) return;

            if (curentNode.right is null && index == 1)
            {
                AddAtTail(val);
                return;
            }
            curentNode = curentNode?.right;
            index--;
        }

        curentNode.left = new Node(val, curentNode.left, curentNode);
        curentNode!.left.left.right = curentNode.left;
    }

    public void DeleteAtIndex(int index)
    {
        if (Head is null) return;
        if (index == 0)
        {
            Head = Head.right;
            if (Head is null) return;
            Head.left = null;
            return;
        }

        var currentNode = Head;
        while (index != 0)
        {
            if (currentNode.right is null) return;
            currentNode = currentNode.right;
            index--;
        }

        currentNode!.left!.right = currentNode.right;
        if (currentNode.right is null) return;
        currentNode.right.left = currentNode.left;
    }
}
