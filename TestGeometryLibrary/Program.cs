using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary;

namespace TestGeometryLibrary
{
    internal class Program
    {
        static void Main()
        {
            double radius = 4.0;
            double circleArea = GeometryCalculator.CalculateCircleArea(radius);
            Console.WriteLine(circleArea);

            // Пример использования метода для вычисления площади треугольника
            double sideA = 3.0, sideB = 4.0, sideC = 5.0;
            double triangleArea = GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);
            Console.WriteLine(triangleArea);
            Console.WriteLine(GeometryCalculator.IsTriangleRightAngled(sideA, sideB, sideC));
        }
    }
}
