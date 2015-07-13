using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class GraphNode : Place {

        public GraphNode() {
            EdgeList = new List<GraphEdge>();
            FieldList = new List<GraphField>();
        }

        public List<GraphEdge> EdgeList { get; set; }
        public List<GraphField> FieldList { get; set; }
    }
}
