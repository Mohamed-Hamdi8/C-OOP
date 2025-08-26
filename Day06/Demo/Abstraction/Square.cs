using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    //Concrete Class ==> Fully Implemented Class
    class Square : Shape, IDraw2D, IDraw3D
    {
        public Square(decimal Dim01, decimal Dim02) : base(Dim01, Dim02)
        {
        }
        public Square(decimal Dim) : base(Dim, Dim)
        {
            Dim01 = Dim02 = Dim;
        }
        public override decimal perimeter => Dim01*4;
        public override decimal CalcArea() => Dim01 * Dim01;
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
