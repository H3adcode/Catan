using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class GraphNode : Place {
        private List<GraphEdge> edgeList = new List<GraphEdge>();

        public List<GraphEdge> EdgeList { get; set; }
    }
}
