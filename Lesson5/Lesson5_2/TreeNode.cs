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
        // добавить узел
        public TreeNode AddItem(int value, TreeNode root)
        {
            if (root == null)
            {
                root = new TreeNode();
                root.Value = value;
            }
            else
            {
                if (root.Value > value)
                {
                    root.LeftChild = AddItem(value, root.LeftChild);
                }
                else
                {
                    root.RightChild = AddItem(value, root.RightChild);
                }
            }
            return root;
        }
        
        //получить узел дерева по значению
        public TreeNode GetNodeByValue(int value)
        {
            if (Value == value) return this;
            if (Value > value)
            {
                return GetNodeByValue(value, LeftChild);
            }
            return GetNodeByValue(value, RightChild);
        }

        private TreeNode GetNodeByValue(int value, TreeNode node)
        {
            if (node == null) return null;

            if (node.Value == value) return node;
            if (node.Value > value)
            {
                return GetNodeByValue(value, node.LeftChild);
            }
            return GetNodeByValue(value, node.RightChild);
        }
        //вывести дерево в консоль
        public void PrintTree(int x, int y, TreeNode node, int delta = 0)
        {
            if (node != null)
            {
                if (delta == 0) delta = x / 2;
                Console.SetCursorPosition(x, y);
                Console.Write($"___({node.Value})___");
                Console.SetCursorPosition(x-1, y+1);
                Console.WriteLine("/         \\");
                PrintTree(x - delta, y + 3, node.LeftChild, delta / 2);
                PrintTree(x + delta, y + 3, node.RightChild, delta / 2);
            }
        }
        public TreeNode RemoveItem(int deleteData, TreeNode root)
        {
            if (root == null)
                return root;
            if (deleteData < root.Value)
            {
                root.LeftChild = RemoveItem(deleteData, root.LeftChild);
            }
            else if (deleteData > root.Value)
            {
                root.RightChild = RemoveItem(deleteData, root.RightChild);
            }
            else if (root.LeftChild != null && root.RightChild != null)
            {
                root.RightChild = RemoveItem(deleteData, root.RightChild);
            }
            else if (root.LeftChild != null)
            {
                return root.LeftChild;
            }
            else
            {
                return root.RightChild;
            }

            return root;

        }
    }
}
