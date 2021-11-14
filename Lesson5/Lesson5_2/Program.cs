using System;

namespace Lesson4_2
{
    class Program
    {
        public static TreeNode tree = new TreeNode();

        static void Main(string[] args)
        {
            
            tree.AddItem(4);
            tree.AddItem(5);
            tree.AddItem(2);
            tree.AddItem(3);
            tree.AddItem(7);
            tree.AddItem(6);
            tree.AddItem(8);
            tree.PrintTree(tree);
        }
    }
}
