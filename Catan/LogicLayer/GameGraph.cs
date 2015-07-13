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

        private void buildGraphRadial(int fieldCount) {
            if ((fieldCount % 6) != 1) {
                //TODO: invalid argument
                Console.Out.WriteLine("invalid argument: fieldcount for radial graph must be of size x*6+1, x={0,1,3,6,10,...}");
                return;
            }
            GraphField[] fields = new GraphField[fieldCount];
            for (int i = 0; i < fieldCount; i++) {              
                GraphField nField = new GraphField();

                //TODO: how to assign coordinates to fields? fixpoint and sequence not clear

                GraphNode[] nodes = new GraphNode[6];
                for (int j = 0; j < 6; j++)
                    nodes[i] = new GraphNode();
                GraphEdge[] edges = new GraphEdge[6];
                GraphEdge nEdge;
                for (int j = 0; j < 6; j++) {
                    nEdge = new GraphEdge();
                    nEdge.NodeOne = nodes[i];
                    nEdge.NodeTwo = nodes[(i + 1) % 6];
                    nodes[i].EdgeList.Add(nEdge);
                    nodes[(i + 1) % 6].EdgeList.Add(nEdge);
                    edges[i] = nEdge;
                }
                nField.Edges = edges;
                nField.Nodes = nodes;
                fields[i] = nField;
            }
        }

        private void buildGraphRect(int fieldCount, int fieldWidth) {
            bool shortRow = (Math.Ceiling((double)fieldCount / (double)fieldWidth) % 2 == 1);
            int idxRowField = 1;
            int idxRow = 0;
            GraphField[] fields = new GraphField[fieldCount];
            for (int i = 0; i < fieldCount; i++) {
                idxRowField++;            
                if((shortRow && idxRowField > fieldWidth - 1) || (!shortRow && idxRowField > fieldWidth)) {
                    idxRow++;
                    idxRowField = 1;
                    shortRow = !shortRow;
                }
                GraphField nField = new GraphField();
                nField.X = 
                nField.Y = idxRow * 4;

                GraphNode[] nodes = new GraphNode[6];
                for (int j = 0; j < 6; j++)
                    nodes[i] = new GraphNode();
                GraphEdge[] edges = new GraphEdge[6];
                GraphEdge nEdge;
                for (int j = 0; j < 6; j++) {
                    nEdge = new GraphEdge();
                    nEdge.NodeOne = nodes[i];
                    nEdge.NodeTwo = nodes[(i + 1) % 6];
                    nodes[i].EdgeList.Add(nEdge);
                    nodes[(i + 1) % 6].EdgeList.Add(nEdge);
                    edges[i] = nEdge;
                }
                nField.Edges = edges;
                nField.Nodes = nodes;
                fields[i] = nField;
            }
        }
    }
}
