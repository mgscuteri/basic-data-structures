using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    class BinaryTree
    {
        public BinaryTreeNode RootNode;

        public void Add(int value)
        {
            if(RootNode == null)
            {
                RootNode = new BinaryTreeNode(value);
            }
            else
            {
                RootNode.Add(value);
            }
        }

        public void InOrderTraversal()
        {
            RootNode.InOrderTraverse();
        }
    }
}
