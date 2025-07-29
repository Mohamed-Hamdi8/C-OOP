using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Rectangle
    {

        #region Private Properties
        private double width;
        private double height;
        #endregion

        #region Public properties with validation
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Width cannot be negative.");
                }
                else
                {
                    width = value;
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Height cannot be negative.");
                }
                else
                {
                    height = value;
                }
            }
        }
        #endregion

        #region Read-only property for Area
        public double Area
        {
            get { return width * height; }
        }
        #endregion

        #region Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}\nHeight: {height}\nArea: {Area}");
        } 
        #endregion
    }
}
