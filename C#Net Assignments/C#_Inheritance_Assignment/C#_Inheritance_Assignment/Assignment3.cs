using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment_E_Commerce
{
    internal class Order
    {
        public int OrderId {  get; set; }
        public int Shipping;
        public virtual double CalculateShippingCost()
        {
            return Shipping = 50;
        }
    }
    class StandardOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return Shipping = 50;
        }
    }
    class ExpressOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return Shipping=100;
        }
    }
    class InternationalOrder : Order
    {
        public override double CalculateShippingCost()
        {
            return Shipping=500;
        }
    }
}
