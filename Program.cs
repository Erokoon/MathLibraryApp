
using System;
using MathLibrary;

namespace MathLibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, 3);
            Point p2 = new Point(4, 6, 8);

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Abstand zwischen p1 und p2: { distance}");

            Vector v1 = new Vector(1, 0, 0);
            Vector v2 = new Vector(0, 2, 0);
            Vector v3 = new Vector(0, 0, 3);


            Point p3 = p1.Add(v1, v2, v3);
            Console.WriteLine($"Neuer Punkt p3 nach Addition: {p3}");

            Vector vSum = new Vector(v1);
            vSum.Add(v2, v3 );
            Console.WriteLine($"Summe v1 + v2 + v3: {vSum}");

            Vector vDiff = new Vector(vSum);
            vDiff.Subtract(v1);
            Console.WriteLine($"Differenz (v1 + v2 + v3) - v1: {vDiff}");

            double dot = v1.DotProduct(v2);
            Console.WriteLine($"Skalarprodukt v1 * v2: {dot}");

            Vector cross = v1.CrossProduct(v2);
            Console.WriteLine($"Kreuzprodukt v1 x v2: {cross}");

            bool collinear = v1.AreCollinear(new Vector(2, 0, 0));
            Console.WriteLine($"v1 und (2, 0, 0) kollinear? {collinear}");

            Vector vn = new Vector(0, 3, 4);
            vn.Normalize();
            Console.WriteLine($"Normalisierter Vektor von (0, 3, 4) : {vn}");


            Console.ReadKey();
        }
    }
}
