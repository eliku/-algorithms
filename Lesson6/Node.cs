using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Node
    {
        public int Value { get; set; }
        public List<Edge> Edges { get; set; } //исходящие связи

        public Node(int value)
        {
            this.Value = value;
            Edges = new List<Edge>();
        }
    }
}
