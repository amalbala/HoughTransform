using System.Drawing;

namespace HoughTransform{
    public class Line2D{
        private double Slope {get;set;}
        private double Yintercept {get; set;}
        private double DistanceToOrigin{get;set;}
        private double Angle {get;set;}
        public Line2D(Point p1, Point p2){
         Slope = (p2.Y - p1.Y)/(p2.X - p1.X);
         Yintercept = p1.Y - (Slope*p1.X);
        }
    }
}