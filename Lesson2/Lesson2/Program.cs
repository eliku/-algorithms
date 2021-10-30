using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ILinkedList newNode = new Node();
            Console.WriteLine(newNode.GetCount());
            newNode.AddNode(6);
            newNode.AddNode(7);
            Console.WriteLine(newNode.GetCount());
        }
    }
}
