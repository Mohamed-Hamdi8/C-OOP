using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    internal class Rectangle
    {
        #region Properties
        public int Width { get; set; }
        public int Height { get; set; }
        #endregion

        #region Constructors
        public Rectangle()
        {
            Width = Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int val)
        {
            Width = Height = val;
        }
        #endregion
    }
}
