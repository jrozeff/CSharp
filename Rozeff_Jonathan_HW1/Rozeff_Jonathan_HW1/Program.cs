//Author: Jonathan Rozeff
//Date: 6 February 2019
//Homework: 1
//Description: Pilot Console Application - Movie Theater User Interface 


using System;
using System.Linq;   //Additional System to allow character check 

namespace Rozeff_Jonathan_HW1
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            
            //Named Constants
            const int intpriceC = 7;
            const int intpriceA = 11;
            const decimal inttaxRate = 0.085m;

            //Variable Declarations
            Boolean bolCodeValid;

            string strCustomerCode;
            string strAdultTick;
            string strChildTick;

            int intchildTick;
            int intadultTick;
            int inttotalTickets;

            decimal decsubtotalA;
            decimal decsubtotalC;
            decimal decSubtotal;
            decimal dectax;
            decimal decGrandTotal;


            //Gets customer code value from user 
            do
            {
                Console.WriteLine("Please enter Customer Code:");
                strCustomerCode = Console.ReadLine();

                bolCodeValid = CheckCode(strCustomerCode);

            } while (bolCodeValid == false);  //Loops if there is a problem with the input 


            //Gets adult ticket input from user
            do
            {
                Console.WriteLine("Enter the number of adult tickets you would like to purchase:");
                strAdultTick = Console.ReadLine();

                intadultTick = CheckTicket(strAdultTick, 1);  //Includes minimum

                if (intadultTick == -1)
                {
                    Console.WriteLine("You must purchse at least one adult ticket!");
                }

            } while (intadultTick == -1);  //Loops if there is a problem with the input


            //Gets child ticket input from user
            do
            {
                Console.WriteLine("Enter the number of child tickets you would like to purchase:");
                strChildTick = Console.ReadLine();

                intchildTick = CheckTicket(strChildTick, 0);  //Includes minimum

            } while (intchildTick == -1);  //Loop if there is a problem with the input


            //Calculations for outputs
            inttotalTickets = Math.Abs(intadultTick) + Math.Abs(intchildTick);

            decsubtotalA = Math.Abs(intpriceA * intadultTick);

            decsubtotalC = Math.Abs(intpriceC * intchildTick);

            decSubtotal = Math.Abs(decsubtotalA + decsubtotalC);

            dectax = Math.Abs(inttaxRate * decSubtotal);

            decGrandTotal = Math.Abs(decSubtotal + dectax);

   
            //Outputs
            Console.WriteLine("Customer Code: " + strCustomerCode.ToUpper());  //Includes uppercase conversion
            Console.WriteLine("Total Items: " + inttotalTickets);
            Console.WriteLine("Adult Subtotal: " + decsubtotalA.ToString("C"));
            Console.WriteLine("Child Subtotal: " + decsubtotalC.ToString("C"));
            Console.WriteLine("Subtotal: " + decSubtotal.ToString("C"));
            Console.WriteLine("Sales Tax: " + dectax.ToString("C"));
            Console.WriteLine("Grand Total: " + decGrandTotal.ToString("C"));


            //Keeps the program running/open
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }



        //Separate method that validates Customer Code input
        public static bool CheckCode(string strInput)
        {
            if (strInput.Length < 4 || strInput.Length > 6)  //Verifies length of Customer Code
            {
                Console.WriteLine("Invalid Customer Code. Please try again.");
                return false; 
            }
            
            if (strInput.All(char.IsLetter) == false)  //Verifies all characters entered
             {
                Console.WriteLine("Invalid Customer Code. Please try again.");
                return false;    
             }
            else
            {
                return true;
            }
        }     



        //Separate method that validates ticket purchases
        public static int CheckTicket(String strInput, Int32 intTicketMin)
        {
            int inttickRes;  //Variable declaration
        
            //Try-Catch block that validates user input
            try 
            {
                inttickRes = Convert.ToInt32(strInput);  //String to Integer conversion
            }
            catch
            {
                return -1;
            }

            if (inttickRes < intTicketMin)  //Verfies minimum ticket input
            {
                return -1;
            }

            return inttickRes;
        }
        

    }
}
