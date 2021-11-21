using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Graph
    {
        private HashSet<Node> nodes;
        public Graph()
        {
            nodes = new HashSet<Node>();
        }
        public void AddVertex(Node v)
        {
            nodes.Add(v);
        }
        public void AddEdge(Node v1, Node v2, int weight)
        {
            v1.Edges.Add(new Edge(v2, weight)); 
            v2.Edges.Add(new Edge(v1, weight));
        }
        public void printGraph()
        {
            foreach (Node v in nodes)
            {
                Console.WriteLine("Вершина " + v.Value.ToString() + ":\n");
                foreach (Edge e in  v.Edges)
                {
                    Console.WriteLine("Ребро " + e.Node.Value.ToString() + ", вес ребра: " + e.Weight.ToString() + "\n");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
