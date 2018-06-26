using System;
using System.Drawing;

namespace HoughTransform{
    public class Point2DArray{

        private Point[] internalArray;
        public Point2DArray(Point[] point2DArray){
            internalArray = point2DArray;
        }

        public int Length(){
            return internalArray.Length;
        }

        public double MaxDistance(){
            double powMaxDistance = 0;

            foreach(Point p in internalArray){
                double powdistance = (p.Y * p.Y) + (p.X * p.X);
                if(powdistance > powMaxDistance) powMaxDistance = powdistance;
            }

            return Math.Sqrt(powMaxDistance);
        }
    }
}