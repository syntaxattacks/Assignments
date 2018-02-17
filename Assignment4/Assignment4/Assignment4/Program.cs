using System;

namespace Assignment4 {
    class Program{
        public static void Main(string[] args) {
            Int32 shapeSelection = GetMenuInput();
            MakeSelection(shapeSelection);

        }// End Main

        private static Int32 GetMenuInput() {
            Int32 testParse;

            // Display menu and receive input
            Console.Write("***AREA CALCULATION***" + "\n" +
                "1. Circle" + "\n" +
                "2. Rectangle" + "\n" +
                "3. Cylinder" + "\n\n" +

                "Please select the shape you would like to calculate the area for(1, 2 or 3): ");
             string menuChoice = Console.ReadLine();

            while (!Int32.TryParse(menuChoice, out testParse)) {
                Console.Write("\n\n Value entered is incorrect. Try again: ");
                menuChoice = Console.ReadLine();
            }// End While


            Int32 output = Convert.ToInt32(menuChoice);

            return output;

        }// End GetMenuInput

        //private static Int32 GetMenuInput() { // I wanted this method to be shorter but I also wanted accurate error handling.
        //    bool repeat = true; // Set flag for error handling
        //    Int32 output = 0; // Return value

        //    while (repeat) { // While loop to take input, validate, and repeat if it not what is expected.
        //        Console.Clear(); // Keep the screen tidy

        //        // Display menu and receive input
        //        Console.Write("***AREA CALCULATION***" + "\n" +
        //                      "1. Circle" + "\n" +
        //                      "2. Rectangle" + "\n" +
        //                      "3. Cylinder" + "\n\n" +

        //                      "Please select the shape you would like to calculate the area for(1, 2 or 3):");
        //        string menuChoice = Console.ReadLine();

        //        /*** ERROR HANDLING ***/
        //        try { output = Convert.ToInt32(menuChoice); }// End Try
        //        catch (FormatException) {
        //            Console.WriteLine("\n\nThe value entered is not a number. Press any key to continue...");
        //            Console.ReadLine();
        //        }// End Catch
        //        catch (OverflowException) {
        //            Console.WriteLine("\n\nThe number cannot fit in an Int32. Press any key to continue...");
        //            Console.ReadLine();
        //        }// End Catch 2
        //        finally {
        //            Int32 testParse; // To be used in initial if statement
        //            if(Int32.TryParse(menuChoice, out testParse)) { // I had to nest the if statements, otherwise the writeline would display in addition to any errors caught
        //                if (output > 0 && output < 4) {
        //                    repeat = false;
        //                } // End Nested If
        //                else if (output > 3 || output < 1) {
        //                    Console.WriteLine("\n\nThe value entered is not a valid option. Press any key to continue...");
        //                    Console.ReadLine();
        //                }// End Else If
        //            }// End If
        //        }// End Finally
        //    }// End While

        //    return output;
            
        //} 

        private static void MakeSelection(int selectionNumber){
            switch (selectionNumber){
                case 1: CreateCircle();
                    break;
               // case 2: CreateRectangle();
                    break;
              //  case 3: CreateCylinder();
                    break;
                default: Console.WriteLine("\n\nIncorrect entry. Press any key to continue");
                    Console.Read();
                    break;
            }// End Switch
        }// End MakeSelection

        public static void CreateCircle() {
            Int32 testParse;
            Console.Write("\n\nPlease enter the radius of the circle in inches: ");
            string input = Console.ReadLine();
            while (!Int32.TryParse(input, out testParse)) {
                Console.Write("\n\n Value entered is incorrect. Try again: ");
                input = Console.ReadLine();
            }
            double radius = Convert.ToDouble(input);
            Circle newCircle = new Circle { Radius = radius };
            Console.Write("\n" + newCircle + "\n" +
                          "Press any key to continue...");
            Console.ReadLine();
        }
    }// End Program
}// End Assignment4
