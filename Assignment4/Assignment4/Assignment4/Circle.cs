using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

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
