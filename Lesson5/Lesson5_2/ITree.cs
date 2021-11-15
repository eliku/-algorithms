using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    interface ITree
    {
        // TreeNode GetRoot();
        TreeNode AddItem(int value, TreeNode root); // добавить узел
        TreeNode RemoveItem(int deleteData, TreeNode root); // удалить узел по значению
        TreeNode GetNodeByValue(int value); //получить узел дерева по значению
        void PrintTree(int x, int y, TreeNode node, int delta = 0); //вывести дерево в консоль  
    }
}
