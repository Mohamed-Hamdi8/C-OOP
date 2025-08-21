using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.interface_Example01
{
    internal interface IType
    {
        // "Public" is the default access modifier inside interface.
        // "Private" is not allowed for the signtures Only (Property ,Method).


        // What You Can Write Inside The Interface ? 

        //1. Signture For Property
        public int MyProperty { get; set; }

        //2. Signture For Method 
        public void MyMethod();

        //3. Defuault Implmented Method [C# 8.0 NEW Feature (.NET Core 3.1 [2019]) ]
        public void print()
        {
            Console.WriteLine("Default Implmented Method");
        }

        ///4. Static Members  [C# 8.0 NEW Feature (.NET Core 3.1 [2019]) ]
        ///   //4.1 Static Feilds
        ///   //4.2 Static Proerties
        ///   //4.1 Static Methods
        ///   //4.1 Static Events
    }
}
