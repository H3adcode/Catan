using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan.LogicLayer {
    class PlaceType {
        public PlaceType() {
            instances = new List<Place>();
        }

        public string name { get; set; }
        public List<Place> instances { get; set; }
    }
}
