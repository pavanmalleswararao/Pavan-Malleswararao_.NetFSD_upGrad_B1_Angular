using System;
using System.Collections.Generic;
using System.Text;

namespace Assingment_Interfaces_Abstract
{
    interface ISales
    {
        int YearlySales();
    }
    abstract class Sales
    {
        public int DailySales()
        {
            return 400;
        }
        public abstract int MonthlySales(int dailySales);
    }
    internal class TotalSales:Sales,ISales
    {
        public override int MonthlySales(int dailySales)
        {
            return dailySales * 30;
        }

        public int YearlySales()
        {
            return DailySales() * 360;
        }
    }
}
