using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    internal class Parent
    {
        public virtual int Salary { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("I am Parent");
        }
    }
    internal class Child : Parent
    {
        //sealed property
        public sealed override int Salary
        { 
            get => base.Salary;
            set => base.Salary = value<5000?5000:value;
        }

        //sealed method
        public sealed override void Print()
        {
            Console.WriteLine("I am Child");
        }

    }

    //sealed class
    internal sealed class GrandChild:Child
    {
        public new int Salary
        {
            get => base.Salary;
            set => base.Salary = value < 10000 ? 10000 : value;
        }
        public new void Print()
        {
            Console.WriteLine("I am GrandChild");
        }
    }
}
