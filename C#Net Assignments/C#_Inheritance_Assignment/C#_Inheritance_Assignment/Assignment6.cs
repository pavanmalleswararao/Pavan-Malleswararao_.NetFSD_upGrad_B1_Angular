using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment_Furniture
{
    class Furniture
    {
        public int OrderId;
        public string OrderDate;
        public string FurnitureType;
        public int Qty;
        public double TotalAmt;
        public string PaymentMode;

        public virtual void GetData()
        {
            Console.WriteLine("Enter Order Id: ");
            OrderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Order Date: ");
            OrderDate = Console.ReadLine();

            Console.WriteLine("Enter Quality:");
            Qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Payment Mode (credit/debit card):");
            PaymentMode = Console.ReadLine();
        }
        public  virtual void ShowData()
        {
            Console.WriteLine("\nOrder Id: " + OrderId);
            Console.WriteLine("Order Date: "+OrderDate);
            Console.WriteLine("Furniture Type: "+ FurnitureType);
            Console.WriteLine("Quality: "+Qty);
            Console.WriteLine("Payment Mode: "+PaymentMode);
            Console.WriteLine("Total Amount: " + TotalAmt);
        }
    }
    class Chair : Furniture
    {
        public string Chairtype;
        public string purpose;
        public string MaterialType;
        public double Rate;

        public override void GetData()
        {
            FurnitureType = "Chair";
            base.GetData();

            Console.WriteLine("Enter chair type (Wood/Steel/Plastic):");
            Chairtype = Console.ReadLine();

            Console.WriteLine("Enter purpose (Home/office):");
            purpose = Console.ReadLine();

            if (Chairtype.ToLower() == "wood")
            {
                Console.WriteLine("Enter wood type (Teak Wood/Rose Wood):");
                MaterialType = Console.ReadLine();
            }
            else if(Chairtype.ToLower() == "steel")
            {
                Console.WriteLine("Enter Steel type (Gray Steel/Green Steel/Brown Steel):");
                MaterialType = Console.ReadLine();
            }
            else if(Chairtype.ToLower()=="plastic")
            {
                Console.WriteLine("Enter Plastic type (Green/Red/Blue/White):");
                MaterialType = Console.ReadLine();
            }

            Console.WriteLine("Enter Rate:");
            Rate=Convert.ToDouble(Console.ReadLine());

            TotalAmt = Rate * Qty;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("\nChair Type: " + Chairtype);
            Console.WriteLine("Purpose: "+purpose);
            Console.WriteLine("Material Type: "+MaterialType);
            Console.WriteLine("Rate: " + Rate);
        }
    }
    class Cot : Furniture
    {
        public string CotType;
        public string MaterialType;
        public string Capacity;
        public double Rate;

        public override void GetData()
        {
            FurnitureType = "Cot";
            base.GetData();

            Console.WriteLine("Enter Cot Type (Wood / Steel):");
            CotType = Console.ReadLine();

            if (CotType.ToLower() == "wood")
            {
                Console.WriteLine("Enter Wood Type (Teak Wood/Rose Wood):");
                MaterialType = Console.ReadLine();
            }
            else if (CotType.ToLower() == "steel")
            {
                Console.WriteLine("Enter Steel Type (Gray Steel/Green Steel/Brown Steel):");
                MaterialType = Console.ReadLine();
            }

            Console.WriteLine("Enter Capacity (Single/Double):");
            Capacity = Console.ReadLine();

            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDouble(Console.ReadLine());

            TotalAmt = Rate * Qty;
        }

        public override void ShowData()
        {
            base.ShowData();

            Console.WriteLine("Cot Type: "+CotType);
            Console.WriteLine("Material Type: "+MaterialType);
            Console.WriteLine("Capacity: "+Capacity);
            Console.WriteLine("Rate: "+Rate);
        }
    }
}
