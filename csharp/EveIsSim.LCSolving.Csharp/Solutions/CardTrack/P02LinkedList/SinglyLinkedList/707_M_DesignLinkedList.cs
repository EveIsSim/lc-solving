// https://leetcode.com/problems/design-linked-list/description/

namespace EveIsSim.LCSolving.Csharp.Solutions.CardTrack.P02LinkedList.SinglyLinkedList;

public class DesignLinkedList
{
    public static void Run()
    {
        // var obj = new MyLinkedList();
        // obj.AddAtHead(7);
        // obj.AddAtHead(2);
        // obj.AddAtHead(1);
        // obj.AddAtIndex(3,0);
        // obj.DeleteAtIndex(2);
        // obj.AddAtHead(6);
        // obj.AddAtTail(4);
        // obj.Get(4);
        // obj.AddAtHead(4);
        // obj.AddAtIndex(5,0);
        // obj.AddAtHead(6);

        //=====================
        // var obj = new MyLinkedList();
        // obj.AddAtHead(1);
        // obj.AddAtTail(3);
        // obj.AddAtIndex(1,2);
        // obj.Get(1);
        // obj.DeleteAtIndex(0);
        // obj.Get(0);

        //=====================
        // var obj = new MyLinkedList();
        // obj.AddAtHead(1);
        // obj.AddAtTail(3);
        // obj.AddAtIndex(3,2);


        //=====================
        var obj = new MyLinkedList();
        obj.AddAtIndex(1, 0);
        obj.Get(0);


        // obj.DeleteAtIndex(1);
        // obj.AddAtIndex(1,2);
        // obj.Get(0);

        var node = obj.Head;
        while (node is not null)
        {
            Console.Write($"{node.Val}, ");
            node = node.Next;
        }
    }

    public class MyLinkedList
    {
        public Node? Head { get; set; }

        public int Get(int index)
        {
            if (Head is null) return -1;
            var currentNode = Head;

            while (index != 0)
            {
                if (currentNode.Next is null) return -1;
                currentNode = currentNode.Next;
                index--;
            }

            return currentNode!.Val;
        }

        public void AddAtHead(int val)
        {
            if (Head is null)
            {
                Head = new Node(val, null, null);
                return;
            }

            Head = new Node(val, null, Head);
            Head!.Next!.Prev = Head;
        }

        public void AddAtTail(int val)
        {
            if (Head is null)
            {
                AddAtHead(val);
                return;
            }

            var currentNode = Head;
            while (currentNode?.Next != null) currentNode = currentNode?.Next;

            currentNode!.Next = new Node(val, currentNode, null);
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            var currentNode = Head;

            while (index != 0)
            {
                if (currentNode is null) return;

                if (currentNode.Next is null && index == 1)
                {
                    AddAtTail(val);
                    return;
                }

                currentNode = currentNode.Next;
                index--;
            }

            currentNode!.Prev = new Node(val, currentNode.Prev, currentNode);
            currentNode.Prev.Prev!.Next = currentNode.Prev;
        }

        public void DeleteAtIndex(int index)
        {
            if (Head is null) return;
            if (index == 0)
            {
                Head = Head.Next;
                if (Head is null) return;
                Head.Prev = null;
                return;
            }

            var currentNode = Head;
            while (index != 0)
            {
                if (currentNode.Next is null) return;
                currentNode = currentNode.Next;
                index--;
            }

            currentNode!.Prev!.Next = currentNode.Next;
            if (currentNode.Next is null) return;
            currentNode.Next.Prev = currentNode.Prev;
        }
    }

    public class Node
    {
        public int Val { get; set; }
        public Node? Prev { get; set; }
        public Node? Next { get; set; }

        public Node(int val, Node? prev, Node? next)
        {
            Val = val;
            Prev = prev;
            Next = next;
        }
    }
}
