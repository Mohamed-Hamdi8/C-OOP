using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interface_Example01
{
    internal class TypeA : IType
    {
        public int MyProperty { get; set; }

        public void MyMethod()
        {
            Console.WriteLine("Cr7 is the best player"); ;
        }
    }
}
