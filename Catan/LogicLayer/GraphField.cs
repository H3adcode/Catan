using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class GraphField : Place {
        private GraphEdge[] edges;
        private GraphNode[] nodes;

        public GraphEdge[] Edges { get; set; }
        public GraphNode[] Nodes { get; set; }
    }
}
