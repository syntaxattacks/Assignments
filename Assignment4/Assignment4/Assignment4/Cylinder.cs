using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double GetArea(double r, double h)
        {
            return (2 * Math.PI * r * h) + (2 * Math.PI * Math.Pow(r,2)); // Mathematic conversion
        }


        public override string ToString()
        {
            return "A cylinder with a radius of " + Radius + " inches and a height of " + Height + " inches is " + Math.Round(GetArea(Radius, Height),2) + " inches.";
        }
    }
}
