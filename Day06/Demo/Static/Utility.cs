using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    internal static class Utility
    {
        #region Static Property / Constant

        //Class Member Attribute : Static Attribute
        private static readonly double pi =3.14;
        //Constant 
        public const double pii=3.14;


        //Class Member Property : Static Property
        //Must Deal With One Of Following : 
        /// 1. Static Attribute
        /// 2. Constant
        public static double PI
        {
            get { return pi; }
        }

        #endregion

        #region Static Constructor
        static Utility()
        {
           // pi = 3.14;
        }
        //Static Constructor [Max Only One Per Class]
        //You Can't Specify Access Modifier Or Parameters For The Static Constructor
        //Will Be Called Once Per Class LifeTime before the first usage of the class

        #endregion

        #region Static Method
        //Class Member Method : Static Method
        public static double CalcCircleArea(double Redius) => (pi * Redius * Redius);
        //Class Member Method : Static Method
        public static double CmToInch(double Cm) => Cm / 2.54;
        #endregion
    }


}
