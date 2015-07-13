using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class GraphEdge : Place {

        public GraphEdge() {
            NodeList = new List<GraphNode>();
            FieldList = new List<GraphField>();
        }

        public List<GraphNode> NodeList { get; set; }
        public List<GraphField> FieldList { get; set; }
    }
}
