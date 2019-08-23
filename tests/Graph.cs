using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    class Graph
    {

        public Graph()
        {
        }

        public static bool BreadthFirstSearch(GraphNode StartNode, GraphNode DestinationNode)
        {
            HashSet<GraphNode> visited = new HashSet<GraphNode> { };

            List<GraphNode> queue = new List<GraphNode> { };
            queue.Add(StartNode);

            while(queue.Count > 0)
            {
                var node = queue[0];
                queue.Remove(node);

                if(DestinationNode == node)
                {
                    return true;
                }
                if (visited.Contains(node))
                {
                    continue;
                }
                visited.Add(node);

                node.Neighbors.ForEach(n => { queue.Add(n); });
            }
            return false;
        }

        public static bool DepthFirstSearch(GraphNode StartNode, GraphNode DestinationNode)
        {
            HashSet<GraphNode> visited = new HashSet<GraphNode> { };
            return StartNode.DepthFirstSearch(DestinationNode, visited); 
        }
    }
}
