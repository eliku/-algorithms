using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class TreeNode:ITree
    {
        public int? Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        public TreeNode Parent { get; set; }

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

        //вывести дерево в консоль
        public void PrintTree(int x, int y, TreeNode node, int delta = 0)
        {
            if (node != null)
            {
                if (delta == 0) delta = x / 2;
                Console.SetCursorPosition(x, y);
                Console.Write($"___({node.Value})___");
                Console.SetCursorPosition(x - 1, y + 1);
                Console.WriteLine("/          \\");
                PrintTree(x - delta, y + 2, node.LeftChild, delta);
                PrintTree(x + delta, y + 2, node.RightChild, delta);
            }
        }
        // обход дерева в ширину
        public string Across(TreeNode node)
        {
            var queue = new Queue<TreeNode>();    // создать новую очередь
            string s = "";
            queue.Enqueue(node);                  // поместить в очередь первый уровень
            while (queue.Count != 0)              // пока очередь не пуста
            {
                if (queue.Peek().LeftChild != null)  queue.Enqueue(queue.Peek().LeftChild);
                if (queue.Peek().RightChild != null) queue.Enqueue(queue.Peek().RightChild);
               
                s+= queue.Peek().Value.ToString() + " ";
                queue.Dequeue();
                
            }
            return s;
        }
        // обход дерева в глубину
        public string Deep(TreeNode node, ref string s)
        {
            var stack = new Stack<TreeNode>();
            stack.Push(node);                     // поместить в стек первый уровень
            if (node != null) 
            {
                s += node.Value.ToString() + " "; // запомнить текущее значение
                Deep(node.LeftChild, ref s);      // обойти левое поддерево
                Deep(node.RightChild, ref s);     // обойти правое поддерево
            }
            return s;
        }
    }
}
