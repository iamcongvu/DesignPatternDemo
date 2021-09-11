using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Services
{
    public class QuarterDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.75;
        }
    }
}