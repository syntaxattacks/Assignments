/*  
    Name: Ian Hann
    Date: 2/3/2018
    Assignment # 1
    Chapter #: 3    Page #:195  Problem #:5
    
    FahrenheitToCelcius.cs -- Write a program that converts a temperature given in Fahrenheit into Celsius.
    Allow the user to enter values for the original Fahrenheit value.  Display the original temperature
    and the formatted converted value.  Number align values.  Use appropriate methods for entering,
    calculating, and outputting results.

    ***********************************************************
    *                       Temperature                       *
    *                                                         *
    *                Fahrenheit        Celcius                 *
    *                                                         *
    *                   xxx°F          xxx°C                  *
    * *********************************************************

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelcius
{
    class Program
    {

        static void Main(string[] args)
        {

            Int32 fTemp = GetFahrenheitTemp(); // Get Fahrenheit Temp

            DisplayConversion(fTemp); // Pass Farenehit temp to convert and display output

        } // End Main

        private static int GetFahrenheitTemp()
        {
            // Prompt for user input
            Console.Write("Please enter the temperature you would like to convert from fahrenheit to celcius: ");
            string userInput = Console.ReadLine();
            
            // Loop to ensure data provided by user is of the proper data type. If incorrect will re-prompt for input.
            while(!Int32.TryParse(userInput, out int tester))
             {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Value entered is incompatible! Please enter an integer value: ");
                Console.ResetColor();
                userInput = Console.ReadLine();

             } // End While Loop


            Int32 fTemp = (Convert.ToInt32(userInput));
            return fTemp;

        } // End GetFahrenheitTemp

        static void DisplayConversion(int fTemp)
        {

            // Display chart with original temp and celcium temp

            // Header
            Console.SetCursorPosition((Console.WindowWidth - 11) / 2, Console.CursorTop); // Center Text
            Console.ForegroundColor = ConsoleColor.Green; // Set color for header
            Console.WriteLine("Temperature\n");
            Console.ResetColor(); // Reset text color to default
            
            // Subheader
            Console.SetCursorPosition((Console.WindowWidth-35) / 2, Console.CursorTop); // Center Text
            Console.Write("{0,-25}","Fahrenheit");
            Console.WriteLine("Celcius\n");

            // Temperature Data
            Console.SetCursorPosition((Console.WindowWidth - 30) / 2, Console.CursorTop); // Center Text
            Console.Write("{0,-20}",fTemp + "\u00B0");
            Console.WriteLine("{0,10}",((fTemp - 32) * .5556) + "\u00B0");


            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();


        } // End DisplayConersion

    } // End Program

} // End FahrenheitToCelcius
