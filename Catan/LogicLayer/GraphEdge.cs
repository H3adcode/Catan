using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class GraphEdge : Place {
        private GraphNode nodeOne, nodeTwo;

        public GraphNode NodeOne { get; set; }
        public GraphNode NodeTwo { get; set; }
    }
}
