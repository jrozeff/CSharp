using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rozeff_Jonathan_Homework2
{
    static class Validation
    {

        //Instantiate Enum
        enum CustomerType {CONSUMER, EVENT};


        //CheckCustomerCode Method
        public static Boolean CheckCode(string strInput)
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


        //CheckCustomerType Method
        public static Boolean CheckCustomerType(string strInput)
        {
            //Converts strInput to Upper and uses Enum to validate
            strInput = strInput.ToUpper();
            return Enum.IsDefined(typeof(CustomerType), strInput);
            
        }


        //CheckServiceFee Method
        public static Decimal CheckServiceFee(string strInput)
        {
            decimal decServiceFee;

            //Try-Catch block that validates user input 
            try
            {
                decServiceFee = Convert.ToDecimal(strInput);
            }
            catch
            {
                return -1;
            }

            if (decServiceFee >= 0)
            {
                return decServiceFee;
            }
            else
            {
                return -1;
            }

        }   


        //CheckItem Method
        public static Int32 CheckItem(String strInput, Int32 intLowerBound)
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

            if (inttickRes < intLowerBound)  //Verfies minimum ticket input
            {
                return -1;
            }

            return inttickRes;

        }

    }
}
