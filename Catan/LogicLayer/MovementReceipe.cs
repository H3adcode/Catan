using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class MovementReceipe {
        public MovementReceipe() {
            movementCostList = new List<MovementCost>();
        }

        public List<MovementCost> movementCostList { get; set; }
    }
}
