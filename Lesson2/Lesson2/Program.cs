using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyNode MainNode = new DoublyNode();

            MainNode.AddNode(6);
            MainNode.AddNode(7);

            MainNode.AddNode(8);

            Node IsNode = new Node {Value = 8};

            MainNode.AddNodeAfter(IsNode, 9);

            MainNode.RemoveNode(2);

            Console.WriteLine(MainNode.GetCount());
            
        }
    }
}
