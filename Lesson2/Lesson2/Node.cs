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

        public int GetCount()
        {
            var node = new Node();
            int Cnt = 0;
            while (node.NextNode != null) Cnt++;
            return Cnt;
        }


    }
    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        int GetCount();                          // возвращает количество элементов в списке
     /*   void AddNode(int value);                 // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index);              // удаляет элемент по порядковому номеру
        void RemoveNode(Node node);              // удаляет указанный элемент
        Node FindNode(int searchValue);          // ищет элемент по его значению
     */
    }

}
