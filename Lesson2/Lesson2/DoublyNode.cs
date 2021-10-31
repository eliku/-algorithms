using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class DoublyNode : ILinkedList
    {
        Node head;                  // головной/первый элемент
        Node tail;                  // последний/хвостовой элемент

        // возвращает количество элементов в списке
        public int GetCount()
        {
            Node current = head;
            int cnt = 0;
            while (current != null) 
            {
                cnt++;
                current = current.NextNode;
            }
            return cnt;
        }
        // добавляет новый элемент списка
        public void AddNode(int value)
        {
            Node node = new Node { Value=value };

            //первый элемент пуст
            if (head == null)
                head = node;
            else
            {
                tail.NextNode  = node;
                node.PrevNode = tail;
            }
            tail = node;
        }
        // добавляет новый элемент списка после определённого элемента
        public void AddNodeAfter(Node node, int value)
        {
            Node nodeAdd = new Node { Value = value};
            //первый элемент пуст
            if (head == null)
                head = nodeAdd;
            else
            {
                //берем первый элемент
                Node current = head;

                while (current.Value != node.Value)
                {
                    current = current.NextNode;
                }
                //если конец списка
                if (node.Value == tail.Value)
                {
                    AddNode(value);
                }
                else
                {
                    nodeAdd.NextNode = current.NextNode;
                    nodeAdd.PrevNode = current;
                    current.NextNode = nodeAdd;
                }
            }
        }
        // удаляет элемент по порядковому номеру
        public void RemoveNode(int index)
        {
            int Cnt = 1;           //количество элементов
            Node current = head;   //берем первый элемент
            Node currentNext, currentPrev;

            if (index <= GetCount())
            {
                while (Cnt < index-1)
                {
                    current = current.NextNode;
                    Cnt++;
                }
                current.NextNode.NextNode.PrevNode = current;
                current.NextNode = current.NextNode.NextNode;
            }
            else
            {
                Console.WriteLine("В списке нет необходимого элемента");
            }
        }
        // удаляет указанный элемент
        public void RemoveNode(Node node)
        {
            int Cnt = 0;           //количество элементов
            //берем первый элемент
            Node current = head;
            try
            {
                while (current.Value != node.Value)
                {
                    current = current.NextNode;
                    Cnt++;
                }
                RemoveNode(Cnt);
            }
            catch (Exception)
            {
                Console.WriteLine("Нет необходимого элемента");
            }
        }
    }
}
