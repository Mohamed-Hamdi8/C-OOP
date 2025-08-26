using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{

    //Abstract Class :
    //Is A Partial Implementation for other classes.
    //Is A Container For Common Code [Fully Implemented Members , Abstract Members] among many classes.
    //You Can't Create an Object from Abstract Class ==> it's Not Fully Implemented].
    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        //Abstract Property
        public abstract decimal perimeter { get;  }
        protected Shape(decimal Dim01 ,decimal Dim02)
        {
            this.Dim01 = Dim01;
            this.Dim02 = Dim02;
        }

        //Abstract Method
        public abstract decimal CalcArea();
    }
}
