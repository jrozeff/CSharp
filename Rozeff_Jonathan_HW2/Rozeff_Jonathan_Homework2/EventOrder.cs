using System;
using System.Collections.Generic;
using System.Text;

namespace Rozeff_Jonathan_Homework2
{
    class EventOrder : Order
    {

        //Auto-implemented properties
        public String CustomerCode { get; set; }
        public Boolean PreferredCustomer { get; set; }

        
        //Private backing variable for ServiceFee (Full-implemented property)
        private Decimal _ServiceFee;
        public Decimal ServiceFee
        {
            get { return _ServiceFee; }
            set { _ServiceFee = ServiceFee; }
        }


        //CalcTotals Method 
        public override void CalcTotals()
        {
            if (PreferredCustomer == true)
            {
                _ServiceFee = 0;
            }
            else
            {
                _ServiceFee = ServiceFee;
            }

            decimal Total = Subtotal + ServiceFee;
        }


        //ToString Method 
        public override String ToString()
        {
            StringBuilder strEO = new StringBuilder();
            strEO.Append("Customer Type: " + CustomerType + "\n");
            strEO.Append("Customer Code: " + CustomerCode + "\n");
            strEO.Append("Total Items: " + TotalItems + "\n");
            strEO.Append("Adult Subtotal: " + AdultSubtotal + "\n");
            strEO.Append("Child Subtotal: " + ChildSubtotal + "\n");
            strEO.Append("Subtotal: " + Subtotal + "\n");
            strEO.Append("Service Fee" + ServiceFee + "\n");
            strEO.Append("Grand Total: " + Total + "\n");


            return strEO.ToString();
        }


    }
}
