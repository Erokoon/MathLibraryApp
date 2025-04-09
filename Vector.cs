using System;

namespace MathLibrary
{
    public class Vector : PointVectorBase
    {
        public static Vector Zero => new Vector(0, 0, 0);
        public static Vector XDir => new Vector(1, 0, 0);
        public static Vector YDir => new Vector(0, 1, 0);
        public static Vector ZDir => new Vector(0, 0, 1);
        public static Vector One => new Vector(1, 1, 1);

        public Vector(double x = 0, double y = 0, double z = 0) 
            : base(x, y, z)
        {
        
        }

        public Vector(PointVectorBase other)
            : base(other)
        {
           
        }

        public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);

        public Vector Add(params Vector[] vectors)
        {
            foreach (var v in vectors)
            {
                X += v.X;
                Y += v.Y;
                Z += v.Z;
            }
            return this;
        }

        public Vector Subtract(params Vector[] vectors)
        {
            foreach (var v in vectors)
            {
                X -= v.X;
                Y -= v.Y;
                Z -= v.Z;
            }
            return this;
        }

        public Vector MultiplyScalar(double scalar)
        {
            X *= scalar;
            Y *= scalar;
            Z *= scalar;
            return this;
        }

        public Vector Normalize()
        {
            double length = Length;
            if (length > Tolerance)
            {
                X /= length;
                Y /= length;
                Z /= length;
            }
            return this;
        }

        public double DotProduct(Vector other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        public Vector CrossProduct(Vector other)
        {
            return new Vector(
                Y * other.Z - Z * other.Y,
                Z * other.X - X * other.Z,
                X * other.Y - Y * other.X
            );
        }

        public bool AreCollinear(Vector other, double tolerance = Tolerance)
        {
            Vector cross = this.CrossProduct(other);
            return Math.Abs(cross.X) < tolerance && Math.Abs(cross.Y) < tolerance && Math.Abs(cross.Z) < tolerance;
        }
    }
}
