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
        
        [Fact]
        public void CountArrayOf2DPoints()
        {
            Point[] arrayp2d = Load2DPointTestData();
            HoughTransform _ht = new HoughTransform(arrayp2d);
            
            var result = _ht.NumberOfInputPoints();      

            Assert.True(result==3,"The array of 2D Points has not been properly loaded.");
        }
    }
}