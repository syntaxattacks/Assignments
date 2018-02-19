using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
