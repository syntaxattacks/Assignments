/*  
    Name: Ian Hann
    Date: 2/18/2018
    Assignment # 4
    Chapter #: 5    Page #:323  Problem #:6
    
    Rectangle.cs -- Write an application that computes the area of a circle, rectangle, and cylinder.  
    Display a menu showing the three options.  Allow users to input which figure they want to see calculated.  
    Based on the value inputted, prompt for appropriate dimensionis and perform the calculations.
*/

namespace Assignment4 {
    class Rectangle {
        /*** DATA FIELDS ***/
        private double length;
        private double width;


        /*** MUTATORS & ACCESSORS***/
        public double Length { get; set; }
        public double Width { get; set; }


        /*** Calculation Methods ***/
        public double GetArea(double l, double w) {
            return l * w; // Mathematic conversion
        }


        public override string ToString() {
            return "The area of a " + Length + " inch by " + Width + " inch rectangle is " + GetArea(Length,Width) + " inches.";
        }
    }
}
