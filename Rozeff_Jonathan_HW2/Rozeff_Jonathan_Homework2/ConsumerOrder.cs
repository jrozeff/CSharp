using System;
using System.Collections.Generic;
using System.Text;

namespace Rozeff_Jonathan_Homework2
{
    class ConsumerOrder : Order
    {
        //Constants
        const Decimal SALES_TAX_RATE = 0.085m;

        //Auto-implemented properties
        public String CustomerName { get; set; }

        //Private backing variable for SalesTaxAmount (Fully-implemented property)
        private Decimal SalesTaxAmt;
        public Decimal SalesTaxAmount
        {
           get { return SalesTaxAmt; }
           set { SalesTaxAmt = SalesTaxAmount; }
        }


        //CalcTotals Method
        public override void CalcTotals()
        {
            decimal SalesTax = Subtotal * SALES_TAX_RATE;
            decimal Total = Subtotal + SalesTaxAmt;
        }


        //ToString Method
        public override String ToString()
        {
            StringBuilder strCO = new StringBuilder();
            strCO.Append("Customer Type: " + CustomerType + "\n");
            strCO.Append("Customer Name: " + CustomerName + "\n");
            strCO.Append("Total Items: " + TotalItems + "\n");
            strCO.Append("Adult Subtotal: " + AdultSubtotal + "\n");
            strCO.Append("Child Subtotal: " + ChildSubtotal + "\n");
            strCO.Append("Subtotal: " + Subtotal.ToString("c") + "\n");
            strCO.Append("Sales Tax: " + SalesTaxAmount + "\n");
            strCO.Append("Grand Total: " + Total.ToString("c") + "\n");


            return strCO.ToString();

        }








    }
}
