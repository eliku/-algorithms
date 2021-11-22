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

        // обход графа в ширину
        public string Across(Node node)
        {
            var queue = new Queue<Node>();     // создать новую очередь
            string s = "";

            for (int i= 0; i<4; i++) node.visited_f= false;

            queue.Enqueue(node);
            node.visited_f = true;

            while (queue.Count != 0)           // пока очередь не пуста
            {
                foreach (Node v in nodes)
                {
                    queue.Enqueue(v);
                    if (!v.visited_f)
                    {
                        s += queue.Peek().Value.ToString() + " ";
                        v.visited_f = true;
                    }
                    queue.Dequeue();
                }
                return s;
            }
          
            return s;
        }

        // обход графа в глубину
        public string Deep(Node node, ref string s)
        {
            var stack = new Stack<Node>();
            stack.Push(node);                     // поместить в стек первый уровень
            foreach (Node v in nodes)
            {
                if (!v.visited_f)
                {
                    s += v.Value.ToString() + " "; // запомнить текущее значение
                    v.visited_f = true;
                    Deep(v, ref s);
                } 
                
            }
            return s;
        }
    }
}
