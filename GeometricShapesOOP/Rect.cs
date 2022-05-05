using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesOOP {
    internal class Rect : Quad {

        public Rect(int sideLong, int sideShort) : base(sideLong, sideShort, sideLong, sideShort) { 
         
        }
        public Rect() { }

        public int Area() {
            return Side1 * Side2;
        }
    }
}
