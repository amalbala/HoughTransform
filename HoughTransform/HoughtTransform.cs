using System.Drawing;
using System;

namespace HoughTransform{

    public class HoughTransform{

        private Point[] InputPoints;

        public HoughTransform(Point[] input2DPoints){

            InputPoints = input2DPoints;
        }

        public int NumberOfInputPoints(){
            return InputPoints.Length;
        }
        
    }
}