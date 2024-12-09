using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemos
{
    //public class DiscountService
    //{
    //    public double CalculateDiscount(string customerType, double totalAmount)
    //    {
    //        if (customerType == "Regular")
    //            return totalAmount * 0.1;

    //        if (customerType == "Premium")
    //            return totalAmount * 0.2;

    //        return 0;
    //    }
    //}

    public abstract class DiscontBase
    {
        public abstract double ApplyDiscount(double totalAmount);
    }

    public class NormalCustomerDiscount : DiscountBase
    {
        public override double ApplyDiscount(double totalAmount)
        {
            return totalAmount * 0.1;
        }
    }

    public class PremiumCustomerDiscount : DiscountBase
    {
        public override double ApplyDiscount(double totalAmount)
        {
            return totalAmount * 0.2;
        }
}





}
