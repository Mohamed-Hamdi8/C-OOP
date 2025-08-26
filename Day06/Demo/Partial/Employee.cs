using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    internal partial class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }

        public partial int DoSomeCode(int X);//if i don,t make implementation for [DoSomeCode(int X)]
                                             //Compiler Will Remove This Line {IL Code WithOut This Line}
        public void Print()
        {
            DoSomeCode(10); //if i don,t make implementation for [DoSomeCode(int X)]
                              //Compiler Will Remove This Line {IL Code WithOut This Line}
        }
    }
}
