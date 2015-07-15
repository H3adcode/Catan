using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class Movement {

        public Movement() {
            movementReceipeList = new List<MovementReceipe>();
        }

        public PlaceType placeType { get; set; }
        public TokenType tokenType { get; set; }
        public List<MovementReceipe> movementReceipeList { get; set; }
    }
}
