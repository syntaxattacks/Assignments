/*  
    Name: Ian Hann
    Date: 2/18/2018
    Assignment # 4
    Chapter #: 5    Page #:323  Problem #:6
    
    Circle.cs -- Write an application that computes the area of a circle, rectangle, and cylinder.  
    Display a menu showing the three options.  Allow users to input which figure they want to see calculated.  
    Based on the value inputted, prompt for appropriate dimensionis and perform the calculations.
*/

using System;

namespace Assignment4 {
    class Circle {
        /*** DATA FIELDS ***/
        private double radius;


        /*** MUTATORS & ACCESSORS***/
        public double Radius { get; set; }


        /*** Calculation Methods ***/
        public double GetArea(double radius) {
           return Math.PI * Math.Pow(radius, 2); // Mathematic conversion
        }


        public override string ToString() {
            return "The radius of the circle is " + Radius + " inches and the area is " + Math.Round(GetArea(Radius), 2) + " inches.";
        }
    }
}
