using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle_App
{
    class Circle
    {
        private float _radius;
        private BorderStyleOption _borderstyle;

        public Circle(float r)
        {
            _radius = r;
        }

        public Circle(float rad, BorderStyleOption border_style)
        {
            _radius = rad;
            _borderstyle = border_style;
        }

        public float Radius
        {
            get
            {
                return _radius;
            }
        }
        public float calculateArea()
        {
            return (float)(3.14 * _radius);
        }

        public BorderStyleOption BorderStyle
        {
            set
            {
                _borderstyle = value;
            }
            get
            {
                return _borderstyle;
            }
        }
    }
}




