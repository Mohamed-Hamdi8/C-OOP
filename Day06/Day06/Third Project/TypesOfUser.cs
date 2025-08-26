using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Third_Project
{
    internal class RegularUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
    internal class PremiumUser : User
    {
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
    internal class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
