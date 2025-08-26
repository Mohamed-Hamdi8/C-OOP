using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    //Concrete Class ==> Fully Implemented Class
    class Rectangle : Shape
    {
        public Rectangle(decimal Dim01, decimal Dim02) : base(Dim01, Dim02)
        {
        }
        public override decimal perimeter { get => (Dim01+Dim02)*2 ; }
        public override decimal CalcArea() => Dim01 * Dim02;
    }
}
