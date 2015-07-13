using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class GraphField : Place {

        public GraphField() {
            EdgeList = new List<GraphEdge>();
            NodeList = new List<GraphNode>();
        }

        public List<GraphEdge> EdgeList { get; set; }
        public List<GraphNode> NodeList { get; set; }
    }
}
