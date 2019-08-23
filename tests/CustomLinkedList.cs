using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    public sealed class CustomLinkedList<T>
    {
        public LinkedListNode<T> HeadNode { get; set; }
        public LinkedListNode<T> TailNode { get; set; }
        public int Count { get; set; }
        public Type ListType { get; set; }

        public CustomLinkedList()
        {
            HeadNode = null;
            TailNode = null;
            ListType = typeof(T);
            Count = 0;
        }

        public void AddToBegginingOfList(LinkedListNode<T> node)
        {
            Count++;
            node.Next = HeadNode;
            HeadNode = node;
        }

        public void AddToEndOfList(LinkedListNode<T> node)
        {
            Count++;
            TailNode = node;

            if(HeadNode == null)
            {
                HeadNode = node;
            } else
            {
                HeadNode.AddToEndOfList(node);
            }
        }

        public void PrintAll()
        {
            if(HeadNode.Next != null)
            {
                HeadNode.PrintNext();
            }
        }

        public T GetAtIndex(int index)
        {
            T nodeVal = HeadNode.GetAtIndex(index);
            return nodeVal;
        }

        public CustomLinkedList<T> ReverseList()
        {
            CustomLinkedList<T> reversedList = new CustomLinkedList<T>();
            
            for(int i = Count - 1; i >= 0; i--)
            {
                reversedList.AddToEndOfList(new LinkedListNode<T>() { Value = GetAtIndex(i) });
            }

            return reversedList;
        }
    }
}
