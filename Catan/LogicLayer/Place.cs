using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class Place {
        
        public int X { get; set; }
        public int Y { get; set; }
        public List<Place> connectedPlaceList { get; set; }
        public List<Token> placedTokenList { get; set; }
        public PlaceType placeType { get; set; }

        public Place() {
            connectedPlaceList = new List<Place>();
            placedTokenList = new List<Token>();
        }
        
    }
}
