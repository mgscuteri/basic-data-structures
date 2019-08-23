using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    public sealed class LinkedListNode<T>
    {
        internal LinkedListNode<T> Previous { get; set; }
        internal LinkedListNode<T> Next { get; set; }
        internal T Value { get; set; }


        public void AddToEndOfList(LinkedListNode<T> node)
        {
            if(Next == null)
            {
                Next = node;
                Next.Previous = this;
            }
            else
            {
                Next.AddToEndOfList(node); ;
            }
        }

        public void PrintNext()
        {
            Console.WriteLine(Value.ToString());

            if (Next != null)
            {
                Next.PrintNext();
            }
            else
            {
                return;
            }
        }

        public void Reverse()
        {
            LinkedListNode<T> tempNext = Next;
            Next = Previous;
            Previous = tempNext;

            if (Next != null)
            {
                Next.Reverse();
            }
            else
            {
                return;
            }
        }


        public T GetAtIndex(int index)
        {
            int i = 0;

            LinkedListNode<T> node;
            GetAtIndexSub(index, ref i, out node);

            return node.Value;
        }

        private void GetAtIndexSub(int index, ref int i, out LinkedListNode<T> node)
        {
            if (i == index)
            {
                node = this;
            }
            else
            {
                i++;
                Next.GetAtIndexSub(index, ref i, out node);
            }
        }

    }
}
