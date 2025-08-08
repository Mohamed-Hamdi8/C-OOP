using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    [Flags]
    internal enum SecurityPrivileges
    {
        Guest = 1 , Developer = 2, Secretary =4 , DBA =8
    }
}
