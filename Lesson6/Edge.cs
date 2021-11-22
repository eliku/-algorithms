using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Edge
    {
        public int Weight { get; set; } //вес связи
        public Node Node { get; set; } // узел, на который связь ссылается

        public Edge(Node dest, int w)
        {
            this.Node = dest;
            this.Weight = w;
        }
    }
}
