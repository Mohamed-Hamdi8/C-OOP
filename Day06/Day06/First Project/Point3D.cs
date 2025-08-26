using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.First_Project
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {
        #region Property
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        #endregion

        #region Constructor
        public Point3D()
        {
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion

        #region Method
        public override string ToString() => $"Point Coordinates: ({X}, {Y}, {Z})";
        public static Point3D ReadPoint(string name)
        {
            Point3D point = new Point3D();
            Console.WriteLine($"Enter values of {name}:");

            Console.Write($"{name}.X = ");
            point.X = Validator.ValidateInt(0);

            Console.Write($"{name}.Y = ");
            point.Y = int.Parse(Console.ReadLine());

            Console.Write($"{name}.Z = ");
            point.Z = Convert.ToInt32(Console.ReadLine());

            return point;
        }
        public int CompareTo(Point3D? other)
        {
            if (this.X == other.X)
            {
                if (this.Y == other.Y)
                {
                    if (this.Z == other.Z)
                        return 0;
                    else
                        return (this.Z > other.Z) ? 1 : -1;
                }
                else
                {
                    return ((this.Y) > other.Y) ? 1 : -1;
                }
            }
            else
            {
                return ((this.X) > other.X) ? 1 : -1;
            }
            }
        public object Clone()
        {
            return new Point3D()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }
        #endregion

        #region Operator OverLoading
        public static bool operator ==(Point3D left, Point3D right)
        {
            return (left.X == right.X) && (left.Y == right.Y) && (left.Z == right.Z);
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return !((left.X == right.X) && (left.Y == right.Y) && (left.Z == right.Z));
        } 
        #endregion

    }
}
