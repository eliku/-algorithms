using System;

namespace Lesson5
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
            tree = tree.AddItem(1, tree);

            tree.PrintTree(Console.WindowWidth / 4, 0, tree);
            Console.SetCursorPosition(0, 25);
            Console.ReadLine();
        }
    }
}
