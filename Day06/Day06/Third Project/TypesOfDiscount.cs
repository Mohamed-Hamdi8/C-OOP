using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Third_Project
{
    internal class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }
        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
            Name = $"Percentage {percentage}%";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)=>(price*quantity)*(Percentage/100);
    }
    internal class FlatDiscount: Discount
    {
        public decimal Amount { get; set; }
        public FlatDiscount(decimal amount)
        {
            Amount = amount;
            Name = $"Flat ${amount}";
        }
        public override decimal CalculateDiscount(decimal price, int quantity) => Amount*Math.Min(quantity,1);
    }
    internal class BuyOneGetOneDiscount: Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One 50%";
        }
        public override decimal CalculateDiscount(decimal price, int quantity) => quantity >1 ? ((price/2)*(quantity/2) ):0;
    }

}
