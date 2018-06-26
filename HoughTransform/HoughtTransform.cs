using System.Drawing;
using System;


namespace HoughTransform{

    public class HoughTransform{

        private Point2DArray InputPoints;
        private int[,] Acumulator;
        private double AngleStep = PI/AngleDivision;        
        static double PI = 3.1416; 
        static int AngleDivision = 10; 

        public HoughTransform(Point[] input2DPoints){

            InputPoints = new Point2DArray(input2DPoints);
            int maxDistance = (int)Math.Floor(InputPoints.MaxDistance());
            Acumulator = new int[360/AngleDivision,maxDistance];
        }

        public int NumberOfInputPoints(){
            return InputPoints.Length();
        }

        private UpdateAcumulator(Point p){

            for(double angle = 0; angle < PI; angle += AngleStep ){
                double distance = (p.X * Math.Cos(angle)) + p.Y * Math.Sin(angle);
                Acumulator[(int)Math.Floor(distance)][angle];
            }
        }

        public Rect[] FindLines(){
            foreach(Point p in InputPoints){
                UpdateAcumulator(p);
            }
        }
        
    }
}