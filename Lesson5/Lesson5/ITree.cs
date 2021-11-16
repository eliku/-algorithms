using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    interface ITree
    {
        TreeNode AddItem(int value, TreeNode root); // добавить узел
        void PrintTree(int x, int y, TreeNode node, int delta = 0); //вывести дерево в консоль 
    }
}
