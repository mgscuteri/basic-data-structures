using System;
using System.Collections.Generic;
using System.Text;

namespace tests
{
    class BinaryTreeNode
    {
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;
        public int Value;

        public BinaryTreeNode(int value)
        {
            Value = value;
        }

        public void Add(int value)
        {
            if(value <= Value)
            {
                if(Left == null)
                {
                    Left = new BinaryTreeNode(value);
                }
                else
                {
                    Left.Add(value);
                }
            }
            else
            {
                if(Right == null)
                {
                    Right = new BinaryTreeNode(value);
                }
                else
                {
                    Right.Add(value);
                }
            }
        }

        public bool Contains(int value)
        {
            if(value == Value)
            {
                return true;
            }
            else
            {
                if(value < Value)
                {
                    if(Left == null)
                    {
                        return false;
                    }
                    else
                    {
                        return Left.Contains(value);
                    }
                }
                else
                {
                    if (Right == null)
                    {
                        return false;
                    }
                    else
                    {
                        return Right.Contains(value);
                    }
                }
            }
        }

        public void InOrderTraverse()
        {
            if (Left != null)
            {
                Left.InOrderTraverse();
            }
            Console.Write(Value.ToString() + ", ");
            if(Right != null)
            {
                Right.InOrderTraverse();
            }

        }
    }
}
