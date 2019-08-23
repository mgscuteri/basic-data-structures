using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace tests
{
    class Tests
    {        
                
        public static void CustomLinkedListTest()
        {
            CustomLinkedList<int> myList = new CustomLinkedList<int>();
            myList.AddToEndOfList(new LinkedListNode<int>() { Value = 3 });
            myList.AddToEndOfList(new LinkedListNode<int>() { Value = 54 });
            myList.AddToEndOfList(new LinkedListNode<int>() { Value = 999 });
            myList.AddToEndOfList(new LinkedListNode<int>() { Value = 11 });
            myList.AddToEndOfList(new LinkedListNode<int>() { Value = 32 });
            myList.AddToBegginingOfList(new LinkedListNode<int>() { Value = 6 });
            myList.PrintAll();

            Console.WriteLine("**Reversing List**");
            CustomLinkedList<int> reversedList = myList.ReverseList();
            reversedList.PrintAll();

            Console.WriteLine("Printing Index 2");
            int myIndex = myList.GetAtIndex(2);
            Console.WriteLine(myIndex.ToString());
        }

        public static void HashTableTest()
        {
            Hashtable ht = new Hashtable();

            for (int i = 0; i < 9999; i++)
            {
                ht.Add(i, "Value " + (i*3).ToString());
            }

            Console.WriteLine(ht[999]);
            
        }

        public static void DictionaryTest()
        {
            Dictionary<int, int> dt = new Dictionary<int, int>();

            for (int i = 0; i < 9999; i++)
            { 
                dt.Add(i, i);
            }

            var a = dt[99];
        }

        public static void BinaryTreeTest(int numOfRandsToAdd)
        {
            var BT = new BinaryTree();
            Random rand = new Random();

            for(int i = 0; i < numOfRandsToAdd; i++)
            {
                BT.Add(rand.Next(1000));
            }

            Console.WriteLine($"Added {numOfRandsToAdd} random ints to binary tree");
            Console.WriteLine("In order traversal: ");

            BT.InOrderTraversal();
        }
    }
}

