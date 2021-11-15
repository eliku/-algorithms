using System;

namespace Lesson4_2
{
    class Program
    {
        public static TreeNode tree = new TreeNode();

        static void Main(string[] args)
        {

            tree = tree.AddItem(4, tree);
            tree = tree.AddItem(5, tree);
            tree = tree.AddItem(2, tree);
            tree = tree.AddItem(3, tree);
            tree = tree.AddItem(10, tree);
            tree = tree.AddItem(4, tree);
            tree = tree.AddItem(23, tree);
            tree = tree.AddItem(34, tree);

            var node = tree.GetNodeByValue(2);

            tree = tree.RemoveItem(2, tree);
            tree.PrintTree(Console.WindowWidth / 3, 0, tree);
            Console.SetCursorPosition(0, 25);
            Console.ReadLine();
        }
    }
}
