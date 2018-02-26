/*  
    Name: Ian Hann
    Date: 2/18/2018
    Assignment # 4
    Chapter #: 5    Page #:323  Problem #:6
    
    Cylinder.cs -- Write an application that computes the area of a circle, rectangle, and cylinder.  
    Display a menu showing the three options.  Allow users to input which figure they want to see calculated.  
    Based on the value inputted, prompt for appropriate dimensionis and perform the calculations.
*/

using System;

namespace Assignment4
{
    class Cylinder
    {
        /*** DATA FIELDS ***/
        private double radius;
        private double height;


        /*** MUTATORS & ACCESSORS***/
        public double Radius { get; set; }
        public double Height { get; set; }


        /*** Calculation Methods ***/
        public double GetArea(double r, double h) {
            return (2 * Math.PI * r * h) + (2 * Math.PI * Math.Pow(r,2)); // Mathematic conversion
        }


        public override string ToString() {
            return "A cylinder with a radius of " + Radius + " inches and a height of " + Height + " inches is " + Math.Round(GetArea(Radius, Height),2) + " inches.";
        }
    }
}
