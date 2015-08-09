using System;
class TriangleSurface
    {
        static void Main()
        {
             //   Write methods that calculate the surface of a triangle by given:
             //       Side and an altitude to it;
             //       Three sides;
             //       Two sides and an angle between them;
             //   Use System.Math.

            Console.WriteLine("Enter side of the triangle and an altitude to it: ");
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("The surface area of the triangle is {0}", CalcSurfaceByAltitude(side, altitude));

            Console.WriteLine("Enter the three sides of a triangle: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("The surface area of the triangle is {0}", CalcSurfaceByThreeSides(a, b, c));

            Console.WriteLine("Enter two sides and an angle between them: ");
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("The surface area of the triangle is {0}", CalcSurfaceByTwoSidesAndAngle(d, e, angle));
        }
  
    static double CalcSurfaceByAltitude (double side, double altitude)
        {
            double surface = (side * altitude) / 2;
            return surface;
        }
    static double CalcSurfaceByThreeSides (double a, double b, double c)
    {
        double semiPerimeter = (a + b + c) / 2;
        double surface = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter * b) * (semiPerimeter * c));
        return surface;
    }
    static double CalcSurfaceByTwoSidesAndAngle (double a, double b, double angle)
    {
        double surface = ((a * b) / 2) * Math.Sin(angle);
        return surface;
    }


}

