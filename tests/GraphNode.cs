using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    class GraphNode
    {
        public List<GraphNode> Neighbors;
        public int Value;

        public GraphNode(int value, List<GraphNode> Neighbors = null)
        {
            if(Neighbors == null)
            {
                Neighbors = new List<GraphNode> { };
            }
            this.Neighbors = Neighbors;

            Value = value;
        }

        public void AddNeighbor(GraphNode newNeighbor)
        {   
            this.Neighbors.Add(newNeighbor);
            newNeighbor.Neighbors.Add(newNeighbor);
        }

        public bool DepthFirstSearch(GraphNode DestNode, HashSet<GraphNode> visited)
        {
            if (visited.Contains(this))
            {
                return false;
            }
            visited.Add(this);
            if (this == DestNode)
            {
                return true;
            }

            foreach(GraphNode neighbor in Neighbors)
            {
                if(neighbor.DepthFirstSearch(DestNode, visited))
                {
                    return true;
                }
            }

            return false;
        }
    }

}
