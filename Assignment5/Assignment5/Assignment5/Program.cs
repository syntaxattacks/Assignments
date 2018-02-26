/*  
    Name: Ian Hann
    Date: 2/25/2018
    Assignment # 5
    Chapter #: 6    Page #: 396  Problem #: 7
    
    Program.cs -- Write a program that produces a multiplication table with 25 rows of computations. 
    Allow the user to input the first and last base values for the multiplication table.  Display a 
    column in the table beginning with the first base input value.  The last column should be the 
    ending base value entered.  The first row should be for 1 times the beginning base, through 1 
    times the ending base.  The last row should be for 25 times the beginning base value, through 
    25 times the ending base value.  Base values range from 2 to 8.  Display an error message if an 
    invalid base is entered.  Display an aesthetically formatted multiplication table.  
*/

using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            Int32 startingNumber = 0, endingNumber = 0;

            while (startingNumber < 2 || startingNumber > 8) // Use while loop to keep asking for input until it is of the expected format
            {
                Console.Write("Please enter a number between 2 and 8 to start the multiplication table: ");
                string input1 = Console.ReadLine();
                startingNumber = ValidateInt(input1);
            }

            while (endingNumber < 2 || endingNumber > 8) // Use while loop to keep asking for input until it is of the expected format
            {
                Console.Write("Please enter a number between 2 and 8 to end the multiplication table: ");
                string input2 = Console.ReadLine();
                endingNumber = ValidateInt(input2);
            }

            if (startingNumber > endingNumber) // Use if statement to test for logical errors in the input
            {
                Console.WriteLine("Starting number cannot be greater than the ending number. Try again. \n\n");
                Main(null); // Restart program to get input
            }
            else if (startingNumber == endingNumber)
            {
                Console.WriteLine("Starting and ending number cannot be the same. Try again.");
                Main(null);// Restart program to get input
            }
            else
            {
                DisplayOutput(startingNumber,endingNumber);
            }

            Console.Write("\nPress any key to continue...");
            Console.Read();


        }

        private static Int32 ValidateInt(string input)
        { // This will take the input string and ensure a proper value is selected

            Int32 output = 0; // Return value


            /*** ERROR HANDLING ***/
            try { output = Convert.ToInt32(input); }// End Try

            catch (FormatException)
            {
                Console.WriteLine("\nThe value entered is not a number.\n");
            }// End Catch

            catch (OverflowException)
            {
                Console.WriteLine("\nThe number cannot fit in an Int32.\n");
            }// End Catch 2

            finally
            {
                
             if (output > 8 || output < 2 )
              {
              Console.WriteLine("\nThe value entered is not between 2 and 8.\n");
              }// End If
            }// End Finally
        // End While

            return output; // Send the int value back to the main variable to test against the while loop

        }

        static void DisplayOutput(Int32 start, Int32 end)
        { // Display multiplication table using a nested for loop

            Console.Clear(); // Make the output look nice and uncluttered
            Console.WriteLine("Multiplication table for numbers " + start + " through " + end + ":\n\n");
            for (Int32 i = 1; i < 26; i++)
            {
                Console.Write("x" + i + "\t");
                for (Int32 j = start; j <= end; j++)
                {
                    Console.Write(j * i + "\t");
                }
                Console.Write("\n");
                
            }

        }


    }
}
