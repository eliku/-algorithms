 using System;
using System.Collections.Generic;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph ourGraph = new Graph();

            // nodes
            Node v0 = new Node(0);
            Node v1 = new Node(1);
            Node v2 = new Node(2);
            Node v3 = new Node(3);

            ourGraph.AddVertex(v0);
            ourGraph.AddVertex(v1);
            ourGraph.AddVertex(v2);
            ourGraph.AddVertex(v3);

            // edges
            ourGraph.AddEdge(v0, v1, 2);
            ourGraph.AddEdge(v1, v2, 3);
            ourGraph.AddEdge(v2, v0, 1);
            ourGraph.AddEdge(v2, v3, 1);
            ourGraph.AddEdge(v3, v2, 4);

            ourGraph.printGraph();

            Console.WriteLine("ОБХОД ГРАФА В ШИРИНУ");
            v0.visited_f = false;
            v1.visited_f = false;
            v2.visited_f = false;
            v3.visited_f = false;
            Console.WriteLine(ourGraph.Across(v0));

            Console.WriteLine("ОБХОД ДЕРЕВА В ГЛУБИНУ");
            v0.visited_f = false;
            v1.visited_f = false;
            v2.visited_f = false;
            v3.visited_f = false;
            string s = "";
            Console.WriteLine(ourGraph.Deep(v0, ref s));

        }
    }



}
