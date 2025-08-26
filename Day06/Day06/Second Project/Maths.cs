using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Second_Project
{
    internal static class Maths
    {
        public static int Add(int a, int b)=> a+b;
        public static int Substract(int a, int b)=> a-b;
        public static int Multiply(int a, int b)=> a*b;
        public static double Divide(double a, double b)=> (b==0)? -1 : a/b ;
    }
}
