using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class GameGraph {
        List<Place> placeList = new List<Place>();

        public GraphField createNewField(GraphEdge[] edges, GraphNode[] nodes) {

            GraphField nField = new GraphField();
            nField.Edges = edges;
            nField.Nodes = nodes;
            placeList.Add(nField);
            return nField;
        }

        private void buildGraph(int fieldWidth, int fieldHeight) {
            GraphNode[] nodes = new GraphNode[6];
            for (int i = 0; i < 6; i++)
                nodes[i] = new GraphNode();
            GraphEdge[] edges = new GraphEdge[6];
            GraphEdge nEdge;
            for (int i = 0; i < 6; i++) {
                nEdge = new GraphEdge();
                nEdge.NodeOne = nodes[i];
                nEdge.NodeTwo = nodes[(i + 1) % 6];
                nodes[i].EdgeList.Add(nEdge);
                nodes[(i + 1) % 6].EdgeList.Add(nEdge);
                edges[i] = nEdge;
            }
            GraphField nField = new GraphField();
            nField.Edges = edges;
            nField.Nodes = nodes;
        }
    }
}
