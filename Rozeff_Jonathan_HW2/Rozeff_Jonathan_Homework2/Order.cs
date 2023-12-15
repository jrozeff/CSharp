using System;
using System.Collections.Generic;
using System.Text;

namespace Rozeff_Jonathan_Homework2
{

    //Enum instantiation
    enum CustomerType {CONSUMER, EVENT};

    abstract class Order
    {

        //Constants 
        const Decimal ADULT_TICKET_PRICE = 11;
        const Decimal CHILD_TICKET_PRICE = 7;

        //Auto-implemented Properties
        public Enum CustomerType { get; set; }

        //
        private Int32 NumberOfAdultTickets;
        public Int32 IntadultTickets
        {
            get { return NumberOfAdultTickets; }
        }

        //
        private Int32 NumberOfChildTickets;
        public Int32 IntchildTickets
        {
            get { return NumberOfChildTickets; }
        }

        //Private backing variable for AdultSubtotal 
        private Decimal _ASubtotal;
        public Decimal AdultSubtotal
        {
            get { return _ASubtotal; }
            set { _ASubtotal = AdultSubtotal; }

        }

        //Private backing variable for ChildSubtotal 
        private Decimal _CSubtotal;
        public Decimal ChildSubtotal
        {
            get { return _CSubtotal; }
            set { _CSubtotal = ChildSubtotal; }
        }

        //Private backing variable for Subtotal 
        private Decimal _Subtotal;
        public Decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = Subtotal; }
        }

        //Read-only property for Total with private backing variable 
        private Decimal _Total;
        public Decimal Total
        {
            get { return _Total; }
        }

        //Read-only property for TotalItems with private backing variable 
        private Decimal _TotalItems;
        public Decimal TotalItems
        {
            get { return _TotalItems; }
        }


        //Calculations
        









        public abstract void CalcTotals();

    }
}
