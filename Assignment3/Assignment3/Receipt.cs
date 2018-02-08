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
    class Receipt
    {
        // DATA FIELDS //
        private int reciptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string custonerName;
        private string customerAddress;
        private long customerPhoneNumber;
        private int itemNumber;
        private string description;
        private double unitPrice;
        private int quantityPurchased;


        // GETTERS & SETTERS //
        public int ReceiptNumber { get; set; }
        public string DateOfPurchase { get; set; } = DateTime.Now.ToString("M/d/yyyy");
        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public long CustomerPhoneNumber { get; set; }
        public int ItemNumber { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public int QuantityPurchased { get; set; } = 1;

        public double TotalPurchase(double cost, int quantity)
        {
            return cost * quantity;

        } // End TotalPurchase

        // STRING OVERRIDE //
        public override string ToString()
        {
            return "**Order Summary** \n" +
                   "Receipt Number: " + ReceiptNumber + "\n" +
                   "Date Of Purchase: " + DateOfPurchase + "\n" +
                   "Customer Number: " + CustomerNumber + "\n" +
                   "Customer Name: " + CustomerName + "\n" +
                   "Customer Address: " + CustomerAddress + "\n" +
                   "Customer Phone Number: " + String.Format("{0:(###) ###-####}", CustomerPhoneNumber) + "\n" +
                   "Item Number: " + ItemNumber + "\n" +
                   "Item Description: " + Description + "\n" +
                   "Unit Price: " + string.Format("{0:C2}" , UnitPrice) + "\n" +
                   "Quantity Purchased: " + QuantityPurchased + "\n" +
                   "Total Purchase Amount: " + string.Format("{0:C2}" , TotalPurchase(UnitPrice,QuantityPurchased))

                   ;
        } // End ToString Override
    } // End Receipt
} // End Assignment3
