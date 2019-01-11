using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewAzureTestWebApp.Models
{

    public class Triangle
    {
        public int[] Sides { get; set; }
        public string Type { get {
                if (Sides[0] == Sides[1] && Sides[1] == Sides[2])
                    return "Equilateral";
                else if (Sides[0] == Sides[1] || Sides[0] == Sides[2] || Sides[1] == Sides[2])
                    return "Isosceles";
                else
                    return "Scalene";
            }
        }


        /// <summary>
        /// Triangle Class speaks for itself.
        /// Given three sides of a triangle, this class serves a triangle's other properties.
        /// In order to form a triangle, sum of length of two sides must be greater than the third side
        /// </summary>
        /// <param name="sides"> Three positive natural numbers</param>
        public Triangle(params int[] sides)
        {

            // Check for correct input
            if (sides.Length != 3)
            {
                throw new ArgumentException("A triangle has only 3 sides");
            }
            if (!CanFormTriangle(sides))
                throw new ArgumentException("Input numbers can't form a triangle");
            
            // Clone to avoid references
            Sides = sides.ToArray();
        }

        private bool CanFormTriangle(int[] sides)
        {
            if (sides.Any(x => x <= 0) ||
                sides[0] + sides[1] <= sides[2] ||
                sides[0] + sides[2] <= sides[1] ||
                sides[1] + sides[2] <= sides[0])
                return false;
            return true;
        }
    }
}