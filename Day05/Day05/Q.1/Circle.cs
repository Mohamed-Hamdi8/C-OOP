using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05.Q._1
{
    internal class Circle : ICircle
    {
        public double Area => Math.PI * Reduis * Reduis;
        public double Reduis { get ; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The Area Of Circle = {Area}");
        }
    }
}
