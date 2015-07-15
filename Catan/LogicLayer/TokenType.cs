using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class TokenType {
        public TokenType() {
            instances = new List<Token>();
            allowedPlaceTypesToPlace = new List<PlaceType>();
            allowedPlaceTypesToMove = new List<PlaceType>();
        }

        public string name { get; set; }
        public List<Token> instances { get; set; }
        public List<PlaceType> allowedPlaceTypesToPlace { get; set; }
        public List<PlaceType> allowedPlaceTypesToMove { get; set; }
    }
}
