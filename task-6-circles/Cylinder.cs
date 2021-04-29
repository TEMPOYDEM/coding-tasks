using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_circles
{
    class Cylinder : ICylinder
    {
        private double _radius;
        private double _height;

        public double Volume()
        {
            return Math.PI * _radius * _radius * _height;
        }
        public void SetHeight(double height)
        {
            _height = height;
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }


    }
}
