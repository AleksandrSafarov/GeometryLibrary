using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be greater than 0");
            }
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("All sides of the triangle must be greater than 0");
            }

            if(a+b<c || a+c<b || b + c < a)
            {
                throw new ArgumentException("There is no triangle with these sides");
            }

            double p = (a + b + c) / 2;
            return (double)Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public static bool IsTriangleRightAngled(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("All sides of the triangle must be greater than 0");
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentException("There is no triangle with these sides");
            }
            ArrayList sides = new ArrayList { a, b, c };
            sides.Sort();
            return Math.Pow((double)sides[2], 2) == Math.Pow((double)sides[0], 2) + Math.Pow((double)sides[1], 2);
        }
    }
}
