using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05.Q._1
{
    internal class Rectangle : IRectangle
    {
        public double Area => Width * Height;
        public double Width { get; set; }
        public double Height { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The Area Of Rectangle = { Area}");
        }
    }
}
