using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    internal class ComplexNumber
    {
        #region Properties
        public int Real { get; set; }
        public int Imaginary { get; set; }
        #endregion

        #region Constructors
        public ComplexNumber()
        {

        }
        public ComplexNumber(int real , int imag)
        {
            Real = real;
            Imaginary = imag;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
        public static ComplexNumber  operator +(ComplexNumber left , ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) + (right?.Imaginary ?? 0)
            };
        }
        public static ComplexNumber  operator -(ComplexNumber left , ComplexNumber right)
        {
            return new ComplexNumber()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) - (right?.Imaginary ?? 0)
            };
        }
        #endregion
    }
}
