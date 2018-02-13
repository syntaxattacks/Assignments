using System;

namespace Assignment4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Int32 shapeSelection = GetMenuInput();
            


            Console.Write("The value entered is " + shapeSelection);
            Console.Read();

        }

        private static Int32 GetMenuInput()
        {
            bool repeat = true; // Set flag for error handling
            Int32 output = 0; // Return value

            while (repeat) // While loop to take input, validate, and repeat if incorrect
            {
                Console.Clear(); // Keep the screen tidy

                // Display menu and receive input
                Console.Write("***AREA CALCULATION***" + "\n" +
                              "1. Circle" + "\n" +
                              "2. Rectangle" + "\n" +
                              "3. Cylinder" + "\n\n" +

                              "Please select the shape you would like to calculate the area for(1, 2 or 3):");

                string menuChoice = Console.ReadLine();

                try
                {
                    output = Convert.ToInt32(menuChoice);
                }// Ent Try
                catch (FormatException)
                {
                    Console.WriteLine("\n\nThe value entered is not a number. ");
                }// End Catch
                catch (OverflowException)
                {
                    Console.WriteLine("\n\nThe number cannot fit in an Int32. ");
                }// End Catch 2
                finally
                {
                    if (output > 3 || output < 1)
                    {
                        Console.WriteLine("\n\nValue entered is not one of the available options. ");
                    } // End If
                }// End Finally

                Console.Write("\nYou have entered " + menuChoice + ". Try again? Enter Y/N: ");
                string loopResponse = Console.ReadLine();

                if (loopResponse == "Y" || loopResponse == "y")
                {
                    repeat = true;
                }// End If
                else
                {
                    repeat = false;
                }// End Else

            }// End While

            return output;
            
        }

       

    }
}
