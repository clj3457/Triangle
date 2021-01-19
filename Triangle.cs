using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        ~Triangle()
        {

        }

        // determine if this is a valid triangle
        // if any two sides added together are less than the third, it's not a triangle
        public bool IsTriangle()
        {
            bool result = true;

            if( ((this.sideA + this.sideB) < this.sideC) ||
                ((this.sideA + this.sideC) < this.sideB) ||
                ((this.sideB + this.sideC) < this.sideA) )
            {
                result = false;
            }
            return result;
        }

        // determine if this is a right angle triangle
        // find which side is longest, that is hypontenuse
        // then use pythagorean theorem 'a2 + b2 = c2'
        public bool IsRightAngle()
        {
            double hypotenuse, side1, side2;

            if(sideA > sideB)
            {
                if(sideA > sideC)
                {
                    hypotenuse = sideA;
                    side1 = this.sideB;
                    side2 = this.sideC;
                }
                else
                {
                    hypotenuse = this.sideC;
                    side1 = this.sideA;
                    side2 = this.sideB;
                }
            }
            else if(sideB > sideC)
            {
                hypotenuse = this.sideB;
                side1 = this.sideA;
                side2 = this.sideC;
            }
            else
            {
                hypotenuse = this.sideC;
                side1 = this.sideA;
                side2 = this.sideB;
            }
            return (Math.Round(Math.Pow(side1, 2)) + Math.Round(Math.Pow(side2, 2)) == Math.Round(Math.Pow(hypotenuse, 2))) ? true : false;
        }

        // classify which type of triangle this is: right, equilateral, isosceles or other triangle
        public string Classify()
        {
            string type = "Triangle";

            // make sure is valid triangle
            if(!IsTriangle())
            {
                type = "Invalid Triangle";
            }
            // determine if equilateral
            else if (this.sideA == this.sideB && this.sideB == this.sideC)
            {
                type = "Equilateral Triangle";
            }
            // determine if isosceles
            else if(this.sideA == this.sideB || this.sideB == this.sideC || this.sideA == this.sideC)
            {
                type = "Isosceles";
                // check if it's an isosceles right triangle
                if(IsRightAngle())
                {
                    type += " Right";
                }
                type += " Triangle";
            }
            // determine if right 
            else if(IsRightAngle())
            {
                type = "Right Triangle";
            }

            // anything else is just a triangle

            return type;
        }
    }
}
