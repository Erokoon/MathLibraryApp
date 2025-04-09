using System;
namespace MathLibrary
{
    public class PointVectorBase
    {
        public const double Tolerance = 1E-10;  
        public double X {  get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        
        public PointVectorBase( double x = 0, double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public PointVectorBase(PointVectorBase sourcePvBase) 
           : this(sourcePvBase.X, sourcePvBase.Y, sourcePvBase.Z) 
        {
            
        }


        public double CalculateDistanceTo(PointVectorBase endPvBase)
        {
            
            return Math.Sqrt( 
            Math.Pow(endPvBase.X - X, 2) +
            Math.Pow(endPvBase.Y - Y, 2) +
            Math.Pow(endPvBase.Z - Z, 2) );
            
        }


        public PointVectorBase CalculateSum(params Vector[] addends)
        {

            foreach (Vector v in addends)
            {
                X += v.X;
                Y += v.Y;
                Z += v.Z; 
            }
            return this;
        }


        public Point AsPoint()
        {
            return new Point(X, Y, Z);
        }


        public Vector AsVector()
        {
            return new Vector (X, Y, Z);
        }


        public override string ToString()
        {
            return $"X: {X:F4}, Y: {Y:F4}, Z: {Z:F4}";
        }
    }
}
