using System;
using System.Collections;
using System.Collections.Generic;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Linked list tests");
            Console.WriteLine("---------------------");
            ExecuteLinkedListTests();

            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Binary Tree Test");
            Console.WriteLine("---------------------");
            ExecuteBinaryTreeTest(100);

            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Graph Tests");
            Console.WriteLine("---------------------");
            ExecuteGraphTests();

            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("MergeSortTest");
            Console.WriteLine("---------------------");
            ExecuteMergeSortTest(100);
            
        }

        public static void ExecuteMergeSortTest(int numOfRandomIntsToSort)
        {
            List<int> unsorted = new List<int> { };
            Random random = new Random();

            for (int i = 0; i < numOfRandomIntsToSort; i++)
            {
                unsorted.Add(random.Next(1000));
            }

            var sorted = SortHelper.MergeSort(unsorted);

            for (int i = 0; i < numOfRandomIntsToSort; i++)
            {
                Console.Write(sorted[i] + ", ");
            }

        }


        public static void ExecuteGraphTests()
        {
            GraphNode originNode = new GraphNode(4);
            GraphNode node1 = new GraphNode(8);
            GraphNode node2 = new GraphNode(2);
            GraphNode node3 = new GraphNode(9);
            GraphNode node4 = new GraphNode(3);
            GraphNode node5 = new GraphNode(1);
            GraphNode node6 = new GraphNode(5);
            GraphNode node7 = new GraphNode(3);
            GraphNode node8 = new GraphNode(2);

            originNode.AddNeighbor(node1);
            originNode.AddNeighbor(node2);
            node2.AddNeighbor(node5);
            node5.AddNeighbor(node3);
            node5.AddNeighbor(node4);
            node4.AddNeighbor(node7);
            node7.AddNeighbor(node8);

            Console.WriteLine("Does path from originNode to node5 exist - BFS ");
            Console.WriteLine(Graph.BreadthFirstSearch(originNode, node5).ToString());
            Console.WriteLine("Does path from originNode to node6 exist - BFS ");
            Console.WriteLine(Graph.BreadthFirstSearch(originNode, node6).ToString());
            Console.WriteLine("Does path from originNode to node5 exist - DFS ");
            Console.WriteLine(Graph.DepthFirstSearch(originNode, node5).ToString());
            Console.WriteLine("Does path from originNode to node6 exist - DFS ");
            Console.WriteLine(Graph.DepthFirstSearch(originNode, node6).ToString());
        }

        public static void ExecuteBinaryTreeTest(int numOfRandsToAddToTree)
        {
            Tests.BinaryTreeTest(numOfRandsToAddToTree);
        }

        public static void ExecuteLinkedListTests()
        {
            Tests.CustomLinkedListTest();
        }
    }
}
