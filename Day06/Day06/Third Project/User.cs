using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Third_Project
{
    internal abstract class User
    {
        public string? User_Name { get; set; }
        public abstract Discount GetDiscount();
    }
}
