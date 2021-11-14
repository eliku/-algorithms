using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class TreeNode : ITree
    {
        public int? Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode Parent { get; set; }

        public override bool Equals(object obj)
        {
            var node = obj as TreeNode;

            if (node == null)
                return false;

            return node.Value == Value;
        }
        public void AddItem(int value)
        {
            if (Value == null || Value == value)
            {
                Value = value;
                return;
            }

            if (Value > value)
            {
                if (LeftChild == null)
                {
                    LeftChild = new TreeNode();
                    Insert(value, LeftChild, this);
                }
                else {
                    Insert(value, new TreeNode(), LeftChild);
                }
            }
            else
            {
                if (RightChild == null)
                {
                    RightChild = new TreeNode();
                    Insert(value, RightChild, this);
                }
                else
                {
                    Insert(value, new TreeNode(), RightChild);
                }
            }
        }
        private void Insert(int value, TreeNode node, TreeNode parent)
        {

            if (node.Value == null || Value == value)
            {
                node.Value = value;
                node.Parent = parent;
                return;
            }
            if (node.Value > value)
            {
                if (LeftChild == null) LeftChild = new TreeNode();
                Insert(value, node.LeftChild, node);
            }
            else
            {
                if (RightChild == null) RightChild = new TreeNode();
                Insert(value, node.RightChild, node);
            }
        }
        public void PrintTree(TreeNode node)
        {
            if (node != null)
            {
                if (node.Parent == null)
                {
                    Console.WriteLine("ROOT:{0}", node.Value);
                }
                else
                {
                    if (node.Parent.LeftChild == node)
                    {
                        Console.WriteLine("Left for {1}  --> {0}", node.Value, node.Parent.Value);
                    }

                    if (node.Parent.RightChild == node)
                    {
                        Console.WriteLine("Right for {1} --> {0}", node.Value, node.Parent.Value);
                    }
                }
                if (node.LeftChild != node)
                {
                    PrintTree(node.LeftChild);
                }
                if (node.RightChild != null)
                {
                    PrintTree(node.RightChild);
                }
            }

        }

    }
}
