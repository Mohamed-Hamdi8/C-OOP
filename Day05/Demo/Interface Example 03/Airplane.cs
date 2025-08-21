using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Example_03
{
    internal class Airplane : Vechile, IMoveable, IFlyable
    {
        public override int Speed { get ; set ; }

        #region IFlyable Method
        void IFlyable.Forward()
        {
            throw new NotImplementedException();
        }
        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }
        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IMoveable Method
        void IMoveable.Forward()
        {
            throw new NotImplementedException();
        }
        void IMoveable.Backward()
        {
            throw new NotImplementedException();
        }
        void IMoveable.Right()
        {
            throw new NotImplementedException();
        }
        void IMoveable.Left()
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
