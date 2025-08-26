using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    internal partial class Employee
    {
        public string? Address { get; set; }

        public partial int DoSomeCode(int X) => X * X;
    }
}
