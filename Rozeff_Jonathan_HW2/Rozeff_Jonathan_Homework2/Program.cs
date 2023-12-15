//Author: Jonathan Rozeff
//Date: 14 February 2019
//Homework: 2
//Description: Console Application - *Updated* Movie Theater User Interface 


using System;
using Rozeff_Jonathan_Homework2;

namespace Rozeff_Jonathan_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Declarations
            Boolean bolOrderProcess;

            string strAdultTickets;
            string strChildTickets;
            string strOrderProcess;

            int IntadultTickets;
            int IntchildTickets;


            //Gets process type from user

            do
            {
                Console.WriteLine("Which type of order do you want to process (CONSUMER or EVENT)");
                strOrderProcess = Console.ReadLine();
                strOrderProcess = strOrderProcess.ToUpper();

                //check the customercode
                bolOrderProcess = Validation.CheckCode(strOrderProcess);

                if (bolOrderProcess == false)
                {
                    Console.WriteLine("Error in input. Please try again");
                }
            } while (bolOrderProcess == false);



            //Gets adult ticket input from user
            do
            {
                Console.WriteLine("Enter the number of adult tickets you would like to purchase: ");
                strAdultTickets = Console.ReadLine();

                IntadultTickets = Validation.CheckItem(strAdultTickets, 1);  //Includes minimum

                if (IntadultTickets == -1)
                {
                    Console.WriteLine("You must purchse at least one adult ticket!");
                }

            } while (IntadultTickets == -1);  //Loops if there is a problem with the input


            //Gets child ticket input from user
            do
            {
                Console.WriteLine("Enter the number of child tickets you would like to purchase:");
                strChildTickets = Console.ReadLine();

                IntchildTickets = Validation.CheckItem(strChildTickets, 0);  //Includes minimum

            } while (IntchildTickets == -1);  //Loop if there is a problem with the input



            if (strOrderProcess == "CONSUMER")
            {
                CheckoutConsumer(IntadultTickets, IntchildTickets);
            }
            else
            {
                CheckoutEvent(IntadultTickets, IntchildTickets);
            }

        }




        //CheckoutConsumer Method
        public static void CheckoutConsumer(Int32 IntadultTickets, Int32 IntchildTickets)
        {
            //Creates an instance of the ConsumerOrder class
            ConsumerOrder ConsumerOrderObj = new ConsumerOrder();

            //Gets consumer name
            Console.WriteLine("What is the name of the customer?");
            ConsumerOrderObj.CustomerName = Console.ReadLine();

            //Calls the method to calculate totals 
            ConsumerOrderObj.CalcTotals();

            //Reads properties from the class (sends? to ConsumerOrder.cs, get)
            String strCustomerName = ConsumerOrderObj.CustomerName;
            Decimal SalesTaxAmount = ConsumerOrderObj.SalesTaxAmount;

            //Displays totals (from ConsumerOrder.cs)
            Console.WriteLine(ConsumerOrderObj.ToString());

        }


        //CheckoutEvent Method
        public static void CheckoutEvent(Int32 IntAdultTickets, Int32 IntChildTickets)
        {
            //Variable Declaration
            string strPreferredCustomer;

            //Creates instance of the EventOrder class
            EventOrder EventOrderObj = new EventOrder();

            //Gets customer code
            Console.WriteLine("Enter customer code:");
            EventOrderObj.CustomerCode = Console.ReadLine();

            //Gets service fee
            Console.WriteLine("Enter the service fee:");
            EventOrderObj.ServiceFee = Console.ReadLine();



            //Gets preferred customer input
            Console.WriteLine("Is this a preferred customer ('Y or y' for Yes any other key for No):");
            strPreferredCustomer = Console.ReadLine();

            if (strPreferredCustomer.Contains('Y') || strPreferredCustomer.Contains('y'))
            {
                EventOrderObj.PreferredCustomer = true;
                //EventOrderObj.PreferredCustomer = 0;
            }
            else
            {
                EventOrderObj.PreferredCustomer = false;
                //EventOrderObj.ServiceFee = decUseServiceFee;  //? What is decUseServiceFee ?
            }

            //Calls method to calculate totals 
            EventOrderObj.CalcTotals();

            //Reads properties from the class (sends? to EventOrder.cs, get)
            String CustomerCode = EventOrderObj.CustomerCode;
            Decimal ServiceFee = EventOrderObj.ServiceFee;   //.ToString("c");  //.ToString ("c") formats to currency
            String PreferredCustomer = EventOrderObj.PreferredCustomer.ToString();

            //Displays totals (from EventOrder.cs)
            Console.WriteLine(EventOrderObj.ToString());

        }




    }
}