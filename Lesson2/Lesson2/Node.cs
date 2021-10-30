using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Node: ILinkedList
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        // возвращает количество элементов в списке
        public int GetCount()
        {
            int Cnt = 0;
            while (this.NextNode != null)
            {
                Cnt++;
               // this.No = node.NextNode;
            }
            return Cnt;
        }
        // добавляет новый элемент списка
        public void AddNode(int value) 
        {
            var newNode = new Node { Value = value, PrevNode = this, NextNode = null};
            this.NextNode = newNode;
            this.PrevNode = this;
        }
    }
}
