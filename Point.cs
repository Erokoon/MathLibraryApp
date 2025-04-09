using System;

namespace MathLibrary
{
    public class Point : PointVectorBase
    {
        public static readonly Point Origin = new Point();
       

        public Point( double x = 0, double y = 0, double z = 0 )
            : base ( x, y, z)
        {

        }
        public Point (Point sourcePoint)
            : base ( sourcePoint)
        {

        }


        public double DistanceTo(Point endPoint)
{
            return CalculateDistanceTo(endPoint); 
}



        public Point Add(params Vector[] addends)
        {
            Point result = new Point(this);   
            result.CalculateSum(addends);     
            return result;                    
        }


    }
}
