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

        // обход дерева в ширину
        public string Across(Node node)
        {
            var queue = new Queue<Node>();     // создать новую очередь
            string s = "";
            bool[] used = new bool[4];         //массив посещали вершину или нет

            used[0] = true;
            queue.Enqueue(node);

            while (queue.Count != 0)          // пока очередь не пуста
            {
                 if (queue.Peek().Edges!=null) queue.Enqueue();
            }
          
            return s;
        }
    }
}
