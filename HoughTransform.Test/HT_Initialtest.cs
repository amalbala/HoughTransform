using Xunit;
using System.Drawing;
using HoughTransform;

namespace HoughTransform.UnitTests.Services
{
    public class HoughTransform_HelloWorld
    {
        private readonly Print _core;

        public HoughTransform_HelloWorld()
        {
            _core = new Print();
        }

        private Point[] Load2DPointTestData(){
            Point[] testData = new Point[] { 
                new Point { X = 0, Y = 1 }, 
                new Point { X = 2, Y = 1 }, 
                new Point { X = 0, Y = 3 } 
                };
                return testData;
        }

        private Point[] PointsOfRect(){
            Point[] testData = new Point[] { 
                new Point { X = 3, Y = 1 }, 
                new Point { X = 2, Y = 2 }, 
                new Point { X = 1, Y = 3 } 
                };
                return testData;
        }
        
        [Fact]
        public void CountArrayOf2DPoints()
        {
            Point[] arrayp2d = Load2DPointTestData();
            HoughTransform _ht = new HoughTransform(arrayp2d);
            
            var result = _ht.NumberOfInputPoints();      

            Assert.True(result==3,"The array of 2D Points has not been properly loaded.");
        }

        public void HoughTransformOfOneLine(){
            Point[] arrayp2D = PointsOfRect();
            double Square2By2 = 2.82842712474619;

            HoughTransform _ht = new HoughTransform(arrayp2D);
            var result = _ht.FindLines();

            Assert.True(result.NumberOfLines == 1, "The number of lines is greater tha 1.");
            Assert.True(result[0].AngularAngle == 45, "The rect Angle is not 45 degree");
            Assert.True(result[0].Distance == Square2By2, "The Distance is not 2 * SquareRoot 2.")

        }
    }
}