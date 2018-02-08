/*  
    Name: Ian Hann
    Date: 2/6/2018
    Assignment # 3
    Chapter #: 4    Page #:254  Problem #:5
    
    Receipt.cs -- Create a Receipt class that could be used by a retail store.  Items to include as data members are receipt number, date of purchase, 
    customer number, customer name and address, customer phone number, item number, description, unit price, and quantity purchased.  For simplicity, you may 
    assume each receipt is for a single ticket item and contains a single item number.  Include appropriate constructors and properties plus an additional
    method that calculates the total cost using the quantity and unit price.  Override the ToString() method to return the information about the customer 
    (name and phone number) and the total cost of the item purchased.  Create a second class to test your Receipt class.

*/

using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            Receipt newReceipt = new Receipt(); // Instantiation

            // SET OBJECT VALUES //
            newReceipt.ReceiptNumber = 287654879;
            newReceipt.DateOfPurchase = DateTime.Now.ToString("M/d/yyyy");
            newReceipt.CustomerNumber = 0072789;
            newReceipt.CustomerName = "Jackson Pollock";
            newReceipt.CustomerAddress = "830 Springs Fireplace Rd, East Hampton, NY 11937";
            newReceipt.CustomerPhoneNumber = 5009875267;
            newReceipt.ItemNumber = 157;
            newReceipt.Description = "Oil Paints, Assorted Pack";
            newReceipt.UnitPrice = 27.99;
            newReceipt.QuantityPurchased = 4;

            // Display Receipt Information
            Console.WriteLine(newReceipt + "\n");
            Console.WriteLine("Press any key to continue...");
            Console.Read();

        } // End Main
    } // End Program
} // End Assignment3
